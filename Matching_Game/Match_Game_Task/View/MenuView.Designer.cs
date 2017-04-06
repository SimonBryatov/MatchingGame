namespace Matching_Game_Task.View
{
    partial class MenuView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Start = new System.Windows.Forms.Button();
            this.label_Highscore = new System.Windows.Forms.Label();
            this.label_Game_Name = new System.Windows.Forms.Label();
            this.label_Choose_TSize = new System.Windows.Forms.Label();
            this.button_3x4 = new System.Windows.Forms.Button();
            this.button_4x5 = new System.Windows.Forms.Button();
            this.button_5x6 = new System.Windows.Forms.Button();
            this.button_animal_pack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_social_pack = new System.Windows.Forms.Button();
            this.label_lastHighscore_TableSize = new System.Windows.Forms.Label();
            this.label_lastHighscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.Brown;
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.Location = new System.Drawing.Point(160, 352);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(330, 67);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Start a Game!";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Highscore
            // 
            this.label_Highscore.AutoSize = true;
            this.label_Highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Highscore.Location = new System.Drawing.Point(442, 9);
            this.label_Highscore.Name = "label_Highscore";
            this.label_Highscore.Size = new System.Drawing.Size(129, 29);
            this.label_Highscore.TabIndex = 1;
            this.label_Highscore.Text = "Highscore:";
            // 
            // label_Game_Name
            // 
            this.label_Game_Name.AutoSize = true;
            this.label_Game_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Game_Name.Location = new System.Drawing.Point(232, 63);
            this.label_Game_Name.Name = "label_Game_Name";
            this.label_Game_Name.Size = new System.Drawing.Size(181, 46);
            this.label_Game_Name.TabIndex = 2;
            this.label_Game_Name.Text = "Match It!";
            // 
            // label_Choose_TSize
            // 
            this.label_Choose_TSize.AutoSize = true;
            this.label_Choose_TSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Choose_TSize.Location = new System.Drawing.Point(252, 127);
            this.label_Choose_TSize.Name = "label_Choose_TSize";
            this.label_Choose_TSize.Size = new System.Drawing.Size(150, 31);
            this.label_Choose_TSize.TabIndex = 6;
            this.label_Choose_TSize.Text = "Table Size:";
            // 
            // button_3x4
            // 
            this.button_3x4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_3x4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_3x4.Location = new System.Drawing.Point(212, 172);
            this.button_3x4.Name = "button_3x4";
            this.button_3x4.Size = new System.Drawing.Size(53, 31);
            this.button_3x4.TabIndex = 7;
            this.button_3x4.Text = "3 x 4";
            this.button_3x4.UseVisualStyleBackColor = false;
            this.button_3x4.Click += new System.EventHandler(this.current_tableSize_button_GotFocus);
            // 
            // button_4x5
            // 
            this.button_4x5.BackColor = System.Drawing.Color.Coral;
            this.button_4x5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_4x5.Location = new System.Drawing.Point(296, 172);
            this.button_4x5.Name = "button_4x5";
            this.button_4x5.Size = new System.Drawing.Size(53, 31);
            this.button_4x5.TabIndex = 8;
            this.button_4x5.Text = "4 x 5";
            this.button_4x5.UseVisualStyleBackColor = false;
            this.button_4x5.Click += new System.EventHandler(this.current_tableSize_button_GotFocus);
            // 
            // button_5x6
            // 
            this.button_5x6.BackColor = System.Drawing.Color.Coral;
            this.button_5x6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5x6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_5x6.Location = new System.Drawing.Point(381, 172);
            this.button_5x6.Name = "button_5x6";
            this.button_5x6.Size = new System.Drawing.Size(53, 31);
            this.button_5x6.TabIndex = 9;
            this.button_5x6.Text = "5 x 6";
            this.button_5x6.UseVisualStyleBackColor = false;
            this.button_5x6.Click += new System.EventHandler(this.current_tableSize_button_GotFocus);
            // 
            // button_animal_pack
            // 
            this.button_animal_pack.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_animal_pack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_animal_pack.Image = global::Matching_Game_Task.Properties.Animals_Pack._1491353118_cow;
            this.button_animal_pack.Location = new System.Drawing.Point(240, 267);
            this.button_animal_pack.Name = "button_animal_pack";
            this.button_animal_pack.Size = new System.Drawing.Size(70, 70);
            this.button_animal_pack.TabIndex = 12;
            this.button_animal_pack.UseVisualStyleBackColor = false;
            this.button_animal_pack.Click += new System.EventHandler(this.current_cardPack_button_GotFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(252, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Card Pack:";
            // 
            // button_social_pack
            // 
            this.button_social_pack.BackColor = System.Drawing.Color.Coral;
            this.button_social_pack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_social_pack.Image = global::Matching_Game_Task.Properties.Social_Pack._1491352343_58_youtube;
            this.button_social_pack.Location = new System.Drawing.Point(331, 267);
            this.button_social_pack.Name = "button_social_pack";
            this.button_social_pack.Size = new System.Drawing.Size(70, 70);
            this.button_social_pack.TabIndex = 13;
            this.button_social_pack.UseVisualStyleBackColor = false;
            this.button_social_pack.Click += new System.EventHandler(this.current_cardPack_button_GotFocus);
            // 
            // label_lastHighscore_TableSize
            // 
            this.label_lastHighscore_TableSize.AutoSize = true;
            this.label_lastHighscore_TableSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_lastHighscore_TableSize.Location = new System.Drawing.Point(566, 12);
            this.label_lastHighscore_TableSize.Name = "label_lastHighscore_TableSize";
            this.label_lastHighscore_TableSize.Size = new System.Drawing.Size(58, 25);
            this.label_lastHighscore_TableSize.TabIndex = 14;
            this.label_lastHighscore_TableSize.Text = "(3x4)";
            // 
            // label_lastHighscore
            // 
            this.label_lastHighscore.AutoSize = true;
            this.label_lastHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_lastHighscore.Location = new System.Drawing.Point(621, 13);
            this.label_lastHighscore.Name = "label_lastHighscore";
            this.label_lastHighscore.Size = new System.Drawing.Size(23, 25);
            this.label_lastHighscore.TabIndex = 15;
            this.label_lastHighscore.Text = "0";
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(655, 440);
            this.Controls.Add(this.label_lastHighscore);
            this.Controls.Add(this.label_lastHighscore_TableSize);
            this.Controls.Add(this.button_social_pack);
            this.Controls.Add(this.button_animal_pack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_5x6);
            this.Controls.Add(this.button_4x5);
            this.Controls.Add(this.button_3x4);
            this.Controls.Add(this.label_Choose_TSize);
            this.Controls.Add(this.label_Game_Name);
            this.Controls.Add(this.label_Highscore);
            this.Controls.Add(this.button_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Highscore;
        private System.Windows.Forms.Label label_Game_Name;
        private System.Windows.Forms.Label label_Choose_TSize;
        private System.Windows.Forms.Button button_3x4;
        private System.Windows.Forms.Button button_4x5;
        private System.Windows.Forms.Button button_5x6;
        private System.Windows.Forms.Button button_animal_pack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_social_pack;
        private System.Windows.Forms.Label label_lastHighscore_TableSize;
        private System.Windows.Forms.Label label_lastHighscore;
    }
}