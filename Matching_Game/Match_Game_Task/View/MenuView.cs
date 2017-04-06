using System;
using System.Drawing;
using System.Windows.Forms;
using Matching_Game_Task.Presenter;

//Game Menu Form:

namespace Matching_Game_Task.View
{
    public partial class MenuView : Form
    {
        public Logic gameLogic;
        private Button current_tableSize_button;
        private Button current_cardPack_button;
        string tableSize;
        private string cardPack;
        public MenuView()
        {
            InitializeComponent();
            current_tableSize_button = button_3x4;
            current_cardPack_button = button_animal_pack;
            tableSize = "3x4";
            cardPack = "Animals_Pack";
            label_lastHighscore.Text = Properties.Settings.Default.Highscore_3x4;
        }
    
        //Updating highscore label:

        public void on_NewGame(string new_highscore)
        {
            label_lastHighscore.Text = new_highscore;
        }

        //Event Handler for "Start" button click event. Starts the game, calling main game logic's "StartAGame" method:

        private void button_Start_Click(object sender, EventArgs e)
        {
            gameLogic.StartAGame(tableSize, cardPack);
        }

        //Next two methods are used to change clicked button's color, setting current game mode(depending on a game table size)
        //and picture pack for cards, and also showing highscore on the screen by the actual mode of the game:

        private void current_tableSize_button_GotFocus(object sender, EventArgs e)
        {
            Button b = sender as Button;
            current_tableSize_button.BackColor = Color.Coral;
            b.BackColor = Color.AntiqueWhite;
            current_tableSize_button = b;
            switch (b.Name)
            {
                case "button_3x4":
                    tableSize = "3x4";
                    label_lastHighscore_TableSize.Text = "(3x4)";
                    label_lastHighscore.Text = Properties.Settings.Default.Highscore_3x4;
                    break;
                case "button_4x5":
                    tableSize = "4x5";
                    label_lastHighscore_TableSize.Text = "(4x5)";
                    label_lastHighscore.Text = Properties.Settings.Default.Highscore_4x5;
                    break;
                case "button_5x6":
                    tableSize = "5x6";
                    label_lastHighscore_TableSize.Text = "(5x6)";
                    label_lastHighscore.Text = Properties.Settings.Default.Highscore_5x6;
                    break;
            }

        }

        private void current_cardPack_button_GotFocus(object sender, EventArgs e)
        {
            Button b = sender as Button;
            current_cardPack_button.BackColor = Color.Coral;
            b.BackColor = Color.AntiqueWhite;
            current_cardPack_button = b;
            switch (b.Name)
            {
                case "button_animal_pack":
                    cardPack = "Animals_Pack";
                    break;
                case "button_social_pack":
                    cardPack = "Social_Pack";
                    break;
            }
        }
    }
}
