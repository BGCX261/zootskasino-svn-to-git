namespace Casino
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lbUpCards = new System.Windows.Forms.ListBox();
            this.lblHoleCard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnHitMe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(141, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbUpCards
            // 
            this.lbUpCards.FormattingEnabled = true;
            this.lbUpCards.Location = new System.Drawing.Point(12, 70);
            this.lbUpCards.Name = "lbUpCards";
            this.lbUpCards.Size = new System.Drawing.Size(120, 95);
            this.lbUpCards.TabIndex = 1;
            // 
            // lblHoleCard
            // 
            this.lblHoleCard.AutoSize = true;
            this.lblHoleCard.Location = new System.Drawing.Point(138, 108);
            this.lblHoleCard.Name = "lblHoleCard";
            this.lblHoleCard.Size = new System.Drawing.Size(25, 13);
            this.lblHoleCard.TabIndex = 2;
            this.lblHoleCard.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sum:";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(49, 168);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(13, 13);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "0";
            // 
            // btnHitMe
            // 
            this.btnHitMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHitMe.Location = new System.Drawing.Point(30, 33);
            this.btnHitMe.Name = "btnHitMe";
            this.btnHitMe.Size = new System.Drawing.Size(75, 31);
            this.btnHitMe.TabIndex = 5;
            this.btnHitMe.Text = "Hit Me!";
            this.btnHitMe.UseVisualStyleBackColor = true;
            this.btnHitMe.Click += new System.EventHandler(this.btnHitMe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hole Card";
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.Location = new System.Drawing.Point(12, 12);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(13, 13);
            this.lblDeck.TabIndex = 7;
            this.lblDeck.Text = "0";
            // 
            // BlackJackGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 195);
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHitMe);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHoleCard);
            this.Controls.Add(this.lbUpCards);
            this.Controls.Add(this.btnStart);
            this.Name = "BlackJackGame";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJackGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbUpCards;
        private System.Windows.Forms.Label lblHoleCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnHitMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeck;
    }
}