using System;
using System.Collections.Generic;
using Extensions;
using Matching_Game_Task.View;
using Matching_Game_Task.Model;
using System.Windows.Forms;
using System.Resources;
using System.Drawing;
using System.Collections;
using System.Globalization;
using System.Reflection;

//Main Logic of the game:

namespace Matching_Game_Task.Presenter
{
    public class Logic
    {
        GameView _gameView;
        MenuView _menuView;
        ResourceManager current_card_pack_rm;
        Timer showTime_Timer;
        public int score;
        string tableSize;
        int firstChoice, secondChoice;
        public List<Card> Deck;
        private List<string> Images;
        private string[] Image_Files;
        public Logic()
        {
            _menuView = new MenuView();
            _menuView.gameLogic = this;
            Images = new List<string>();
            Deck = new List<Card>();
            firstChoice = -1;
            secondChoice = -2;
            score = 0;
            showTime_Timer = new Timer();
            showTime_Timer.Interval = 450;
            showTime_Timer.Tick += new EventHandler(showTime_Timer_Tick);

            Application.Run(_menuView);
        }

        //Grabbing all images from proper resource file:

        private void GetAllImages(string cardPack)
        {
            //string resourcesFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/Animal_Pack/");
            //Image_Files = Directory.GetFiles(resourcesFolderPath, ".png", SearchOption.AllDirectories);
            //Images.Shuffle();
            Images.Clear();
            ResourceSet ImagesSet = null;
            //switch (cardPack)
            //{
            //    case "Animals_Pack":
            //        ImagesSet = Properties.Animals_Pack.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            //        break;
            //    case "Social_Pack":
            //        ImagesSet = Properties.Social_Pack.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            //        break;
            //}

            ImagesSet = current_card_pack_rm.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (DictionaryEntry entry in ImagesSet)
            {
                Images.Add(entry.Key as string);
            }
            Images.Shuffle(); //see "Extensions.cs" for ".Shuffle()" method
        }

        //Creating a new random game deck: 

        private void CreateADeck(int cardTypes_Amount)
        {
            Deck.Clear();
            for (int i = 0; i < cardTypes_Amount; i++)
            {
                //Deck.Add(new Card(i, Properties.Animals_Pack.ResourceManager.GetObject(Images[i]) as Image));
                Deck.Add(new Card(i, current_card_pack_rm.GetObject(Images[i]) as Image));
                Deck.Add(Deck[2 * i]);
            }
            Deck.Shuffle();
        }

        // Starting a game based on chosen table size and card pack:

        public void StartAGame(string tableSize, string cardPack)
        {
            this.tableSize = tableSize;
            _gameView = new GameView();
            _gameView.gameLogic = this;
            string res_location = "Matching_Game_Task.Properties.{0}";
            current_card_pack_rm = new ResourceManager(string.Format(res_location, cardPack), Assembly.GetExecutingAssembly());
            int cardTypes_Amount = 0;
            score = 0;
            switch (tableSize)
            {
                case "3x4":
                    cardTypes_Amount = 6;
                    break;
                case "4x5":
                    cardTypes_Amount = 10;
                    break;
                case "5x6":
                    cardTypes_Amount = 15;
                    break;


            }
            GetAllImages(cardPack);
            CreateADeck(cardTypes_Amount);
            _gameView.PrepareGameTable(tableSize, cardTypes_Amount);
            _menuView.Hide();
            _gameView.Show();
        }

        //Checking number of clicks and match condition of chosen cards.
        //If cards don't match, start timer for showing cards' pictures: 

        public void on_Card_Click(int card_num)
        {
            if (!Deck[card_num].matched)
            {
                if (firstChoice < 0)
                {
                    firstChoice = card_num;
                    _gameView.ShowCard(card_num, Deck[card_num].card_Image);
                }
                else if (secondChoice < 0 && firstChoice != card_num)
                {
                    secondChoice = card_num;
                    _gameView.ShowCard(card_num, Deck[card_num].card_Image);
                    if (Deck[firstChoice].card_Type == Deck[secondChoice].card_Type)
                    {
                        Match_Action(true);
                    }
                    else
                    {
                        showTime_Timer.Start();
                    }
                }
            }
        }

        //Action, based on match condition. If false, it stops the timer, hides card pictures and sets choice variables to negative values.
        //Else, we're mark the cards "matched" and checking for the win situation:

        private void Match_Action(bool match)
        {
            showTime_Timer.Stop();
            if (match)
            {
                Deck[firstChoice].matched = true;
                Deck[secondChoice].matched = true;
                _gameView.Cards[firstChoice].BackColor = _gameView.BackColor;
                _gameView.Cards[secondChoice].BackColor = _gameView.BackColor;
                CheckForWin();
            }
            else
            {
                _gameView.HideCard(firstChoice);
                _gameView.HideCard(secondChoice);
                score++;
                _gameView.SetScore();
            }
            firstChoice = -1;
            secondChoice = -2;
        }

        //Timer tick Event Handler. If time runs out, we're calling action to hide chosen cards:

        private void showTime_Timer_Tick(object sender, EventArgs e)
        {
            Match_Action(false);
        }

        //Checking for win situation. On "false", game continues. If no unmatched cards in a deck found, 
        //showing the final score and asking player for another round.

        private void CheckForWin()
        {
            bool win = true;
            foreach (Card card in Deck)
            {
                if (card.matched == false)
                {
                    win = false;
                }
            }
            if (win)
            {
                MessageBox.Show(String.Format("You matched all the icons! \nYour final score is {0}", score), "Congratulations!");
                string highscore_by_tableSize = string.Format("Highscore_{0}", tableSize);
                if (Convert.ToInt32(Properties.Settings.Default[highscore_by_tableSize]) > score)
                {
                    Properties.Settings.Default[highscore_by_tableSize] = score.ToString();
                    Properties.Settings.Default.Save();
                    string result = "New highscore on {0} is {1}";
                    MessageBox.Show(string.Format(result, tableSize, score), "Highscore is beaten!");
                    _menuView.on_NewGame(score.ToString());
                }
                DialogResult try_again = MessageBox.Show("Try again?", ":)", MessageBoxButtons.YesNo);
                if (try_again == DialogResult.Yes)
                {
                    _menuView.Show();
                    _gameView.Dispose();
                }
                else
                {
                    _gameView.Close();
                }
            }
        }
    }
}

