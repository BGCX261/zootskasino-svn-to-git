namespace CardGamesForms
{
    partial class BlackJackGame
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
            this.lblSumOfCards = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUpCards = new System.Windows.Forms.ListBox();
            this.lblHoleCard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSumOfCards);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbUpCards);
            this.panel1.Controls.Add(this.lblHoleCard);
            this.panel1.Controls.Add(this.label2);
            // 
            // lblSumOfCards
            // 
            this.lblSumOfCards.AutoSize = true;
            this.lblSumOfCards.Location = new System.Drawing.Point(255, 138);
            this.lblSumOfCards.Name = "lblSumOfCards";
            this.lblSumOfCards.Size = new System.Drawing.Size(13, 13);
            this.lblSumOfCards.TabIndex = 11;
            this.lblSumOfCards.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Up Cards";
            // 
            // lbUpCards
            // 
            this.lbUpCards.FormattingEnabled = true;
            this.lbUpCards.Location = new System.Drawing.Point(188, 36);
            this.lbUpCards.Name = "lbUpCards";
            this.lbUpCards.Size = new System.Drawing.Size(120, 95);
            this.lbUpCards.TabIndex = 8;
            // 
            // lblHoleCard
            // 
            this.lblHoleCard.AutoSize = true;
            this.lblHoleCard.Location = new System.Drawing.Point(49, 79);
            this.lblHoleCard.Name = "lblHoleCard";
            this.lblHoleCard.Size = new System.Drawing.Size(25, 13);
            this.lblHoleCard.TabIndex = 7;
            this.lblHoleCard.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hole Card";
            // 
            // BlackJackGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(374, 343);
            this.Name = "BlackJackGame";
            this.Load += new System.EventHandler(this.BlackJackGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSumOfCards;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbUpCards;
        private System.Windows.Forms.Label lblHoleCard;
        private System.Windows.Forms.Label label2;
    }
}
