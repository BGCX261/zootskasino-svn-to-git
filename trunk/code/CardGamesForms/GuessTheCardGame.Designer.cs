namespace CardGamesForms
{
    partial class GuessTheCardGame
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
            this.lblHint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPickDeck = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGuesses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMysteryCard = new System.Windows.Forms.Label();
            this.lblMCard = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHint);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbPickDeck);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblGuesses);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblMysteryCard);
            this.panel1.Controls.Add(this.lblMCard);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(110, 117);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(62, 13);
            this.lblHint.TabIndex = 19;
            this.lblHint.Text = "Hot or Not?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hint:";
            // 
            // cbPickDeck
            // 
            this.cbPickDeck.FormattingEnabled = true;
            this.cbPickDeck.Location = new System.Drawing.Point(163, 83);
            this.cbPickDeck.Name = "cbPickDeck";
            this.cbPickDeck.Size = new System.Drawing.Size(153, 21);
            this.cbPickDeck.TabIndex = 17;
            this.cbPickDeck.SelectedIndexChanged += new System.EventHandler(this.cbPickDeck_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "out of 5 guesses.";
            // 
            // lblGuesses
            // 
            this.lblGuesses.AutoSize = true;
            this.lblGuesses.Location = new System.Drawing.Point(191, 57);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(13, 13);
            this.lblGuesses.TabIndex = 15;
            this.lblGuesses.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pick Your Guess";
            // 
            // lblMysteryCard
            // 
            this.lblMysteryCard.AutoSize = true;
            this.lblMysteryCard.Location = new System.Drawing.Point(51, 76);
            this.lblMysteryCard.Name = "lblMysteryCard";
            this.lblMysteryCard.Size = new System.Drawing.Size(25, 13);
            this.lblMysteryCard.TabIndex = 13;
            this.lblMysteryCard.Text = "???";
            // 
            // lblMCard
            // 
            this.lblMCard.AutoSize = true;
            this.lblMCard.Location = new System.Drawing.Point(34, 47);
            this.lblMCard.Name = "lblMCard";
            this.lblMCard.Size = new System.Drawing.Size(68, 13);
            this.lblMCard.TabIndex = 12;
            this.lblMCard.Text = "Mystery Card";
            // 
            // GuessTheCardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(374, 343);
            this.Name = "GuessTheCardGame";
            this.Load += new System.EventHandler(this.GuessTheCardGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPickDeck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGuesses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMysteryCard;
        private System.Windows.Forms.Label lblMCard;
    }
}
