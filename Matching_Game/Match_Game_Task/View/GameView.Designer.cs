namespace Matching_Game_Task.View
{
    partial class GameView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_gameTable = new System.Windows.Forms.TableLayoutPanel();
            this.label_sc_lbl = new System.Windows.Forms.Label();
            this.label_currentScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_gameTable
            // 
            this.tableLayoutPanel_gameTable.AutoSize = true;
            this.tableLayoutPanel_gameTable.ColumnCount = 4;
            this.tableLayoutPanel_gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel_gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel_gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel_gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel_gameTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel_gameTable.Location = new System.Drawing.Point(34, 69);
            this.tableLayoutPanel_gameTable.Name = "tableLayoutPanel_gameTable";
            this.tableLayoutPanel_gameTable.RowCount = 3;
            this.tableLayoutPanel_gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel_gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel_gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel_gameTable.Size = new System.Drawing.Size(380, 390);
            this.tableLayoutPanel_gameTable.TabIndex = 0;
            // 
            // label_sc_lbl
            // 
            this.label_sc_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_sc_lbl.AutoSize = true;
            this.label_sc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sc_lbl.Location = new System.Drawing.Point(181, 24);
            this.label_sc_lbl.Name = "label_sc_lbl";
            this.label_sc_lbl.Size = new System.Drawing.Size(75, 26);
            this.label_sc_lbl.TabIndex = 1;
            this.label_sc_lbl.Text = "Score:";
            // 
            // label_currentScore
            // 
            this.label_currentScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_currentScore.AutoSize = true;
            this.label_currentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_currentScore.Location = new System.Drawing.Point(249, 24);
            this.label_currentScore.Name = "label_currentScore";
            this.label_currentScore.Size = new System.Drawing.Size(24, 26);
            this.label_currentScore.TabIndex = 2;
            this.label_currentScore.Text = "0";
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(467, 452);
            this.Controls.Add(this.label_currentScore);
            this.Controls.Add(this.label_sc_lbl);
            this.Controls.Add(this.tableLayoutPanel_gameTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_gameTable;
        private System.Windows.Forms.Label label_sc_lbl;
        private System.Windows.Forms.Label label_currentScore;
    }
}

