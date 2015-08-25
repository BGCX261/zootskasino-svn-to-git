namespace Casino
{
    partial class GuessTheCard
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
            this.lblDeck = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGuesses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHints = new System.Windows.Forms.Label();
            this.cbPickDeck = new System.Windows.Forms.ComboBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.Location = new System.Drawing.Point(12, 17);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(33, 13);
            this.lblDeck.TabIndex = 0;
            this.lblDeck.Text = "Deck";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(149, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guess The Card!";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.Location = new System.Drawing.Point(22, 89);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(59, 31);
            this.lblCardName.TabIndex = 3;
            this.lblCardName.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose Your Guess";
            // 
            // lblGuesses
            // 
            this.lblGuesses.AutoSize = true;
            this.lblGuesses.Location = new System.Drawing.Point(146, 89);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(13, 13);
            this.lblGuesses.TabIndex = 7;
            this.lblGuesses.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hint: ";
            // 
            // lblHints
            // 
            this.lblHints.AutoSize = true;
            this.lblHints.Location = new System.Drawing.Point(139, 140);
            this.lblHints.Name = "lblHints";
            this.lblHints.Size = new System.Drawing.Size(62, 13);
            this.lblHints.TabIndex = 9;
            this.lblHints.Text = "Hot or Not?";
            // 
            // cbPickDeck
            // 
            this.cbPickDeck.FormattingEnabled = true;
            this.cbPickDeck.Location = new System.Drawing.Point(133, 107);
            this.cbPickDeck.Name = "cbPickDeck";
            this.cbPickDeck.Size = new System.Drawing.Size(121, 21);
            this.cbPickDeck.TabIndex = 10;
            this.cbPickDeck.SelectedIndexChanged += new System.EventHandler(this.cbPickDeck_SelectedIndexChanged);
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(12, 120);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(35, 13);
            this.lblCard.TabIndex = 11;
            this.lblCard.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "out of 5";
            // 
            // GuessTheCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.cbPickDeck);
            this.Controls.Add(this.lblHints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGuesses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDeck);
            this.Name = "GuessTheCard";
            this.Text = "GuessTheCard";
            this.Load += new System.EventHandler(this.GuessTheCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGuesses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHints;
        private System.Windows.Forms.ComboBox cbPickDeck;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label label3;
    }
}