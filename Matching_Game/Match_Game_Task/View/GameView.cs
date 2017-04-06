using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Matching_Game_Task.Presenter;

//Game Screen Form:

namespace Matching_Game_Task.View
{
    public partial class GameView : Form
    {
        public Logic gameLogic;
        public List<PictureBox> Cards;
        public GameView()
        {
            InitializeComponent();
            Cards = new List<PictureBox>();
            this.FormClosed += new FormClosedEventHandler(this.MainView_FormClosed);
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel_gameTable_Paint(object sender, PaintEventArgs e)
        {

        }

        //Setting TableLayoutPanel for cards' picturebox elements:

        private void SetLayoutPanel(int rows, int columns)
        {

            tableLayoutPanel_gameTable.Controls.Clear();
            tableLayoutPanel_gameTable.RowStyles.Clear();
            tableLayoutPanel_gameTable.ColumnStyles.Clear();
            tableLayoutPanel_gameTable.RowCount = 0;
            tableLayoutPanel_gameTable.ColumnCount = 0;       
            for (int i = 0; i < rows; i++) {
                tableLayoutPanel_gameTable.RowCount++;
                RowStyle r_style = new RowStyle(SizeType.AutoSize);
                tableLayoutPanel_gameTable.RowStyles.Add(r_style);
            }
            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel_gameTable.ColumnCount++;
                ColumnStyle c_style = new ColumnStyle(SizeType.AutoSize);
                tableLayoutPanel_gameTable.ColumnStyles.Add(c_style);
            }
        }

        //Creating picturebox elements for cards in a deck and setting event handlers for clicks and MouseEnter/MouseLeave color changes:  

        private void Add_Cards(int cardTypes_Amount)
        {
            Cards.Clear();
            for (int i = 0; i < cardTypes_Amount*2; i++ )
            {
                Cards.Add(new PictureBox());
                Cards[i].Height = 105;
                Cards[i].Width = 95;
                Cards[i].SizeMode = PictureBoxSizeMode.CenterImage;
                Cards[i].BackColor = Color.Coral;
                tableLayoutPanel_gameTable.Controls.Add(Cards[i]);
                Cards[i].Click += new EventHandler(Card_Click);
                Cards[i].MouseEnter += new EventHandler(Card_MouseEnter);
                Cards[i].MouseLeave += new EventHandler(Card_MouseLeave);


            }
        }

        //Card's picturebox click handler:

        private void Card_Click(object sender, EventArgs e)
        {
            PictureBox card = sender as PictureBox;
            gameLogic.on_Card_Click(Cards.IndexOf(card));
            
        }

        //Card's picturebox MouseEnter handler:

        private void Card_MouseEnter(object sender, EventArgs e)
        {
            PictureBox card = sender as PictureBox;
            if (!gameLogic.Deck[Cards.IndexOf(card)].matched)
            {
                card.BackColor = Color.AntiqueWhite;
            }

        }

        //Card's picturebox MouseLeave handler:

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            PictureBox card = sender as PictureBox;
            if (!gameLogic.Deck[Cards.IndexOf(card)].matched)
            {
                card.BackColor = Color.Coral;
            }
        }

        //Showing the selected cards' pictures:

        public void ShowCard(int card_Num, Image card_Image)
        {
            Cards[card_Num].Image = card_Image;
        }

        //Hiding showed cards' pictures:

        public void HideCard(int card_Num)
        {
            Cards[card_Num].Image = null;
        }

        //Updating score on the screen after unmatched pair event:

        public void SetScore()
        {
            label_currentScore.Text = gameLogic.score.ToString();
        }

        //Setting window size:

        public void setWindowSize(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        //Preparing Game Table, depending on the table size:

        public void PrepareGameTable(string tableSize, int cardTypes_Amount)
        {
            switch (tableSize)
            {
                case "3x4":
                    SetLayoutPanel(3, 4);
                    setWindowSize(483, 491);
                    break;
                case "4x5":
                    SetLayoutPanel(4, 5);
                    setWindowSize(600, 600);
                    break;
                case "5x6":
                    SetLayoutPanel(5, 6);
                    setWindowSize(700, 700);
                    break;
            }
            Add_Cards(cardTypes_Amount);
        }
    }

    }

