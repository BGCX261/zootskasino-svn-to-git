namespace Casino
{
    partial class Casino
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
            this.btnPoker = new System.Windows.Forms.Button();
            this.btnGuessCard = new System.Windows.Forms.Button();
            this.btnBlackJack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPoker
            // 
            this.btnPoker.Location = new System.Drawing.Point(12, 51);
            this.btnPoker.Name = "btnPoker";
            this.btnPoker.Size = new System.Drawing.Size(75, 23);
            this.btnPoker.TabIndex = 1;
            this.btnPoker.Text = "Poker";
            this.btnPoker.UseVisualStyleBackColor = true;
            this.btnPoker.Click += new System.EventHandler(this.btnPoker_Click);
            // 
            // btnGuessCard
            // 
            this.btnGuessCard.Location = new System.Drawing.Point(108, 44);
            this.btnGuessCard.Name = "btnGuessCard";
            this.btnGuessCard.Size = new System.Drawing.Size(75, 36);
            this.btnGuessCard.TabIndex = 2;
            this.btnGuessCard.Text = "Guess The Card";
            this.btnGuessCard.UseVisualStyleBackColor = true;
            this.btnGuessCard.Click += new System.EventHandler(this.btnGuessCard_Click);
            // 
            // btnBlackJack
            // 
            this.btnBlackJack.Location = new System.Drawing.Point(205, 51);
            this.btnBlackJack.Name = "btnBlackJack";
            this.btnBlackJack.Size = new System.Drawing.Size(75, 23);
            this.btnBlackJack.TabIndex = 3;
            this.btnBlackJack.Text = "Black Jack";
            this.btnBlackJack.UseVisualStyleBackColor = true;
            this.btnBlackJack.Click += new System.EventHandler(this.btnBlackJack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Your Game:";
            // 
            // Casino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 106);
            this.Controls.Add(this.btnBlackJack);
            this.Controls.Add(this.btnGuessCard);
            this.Controls.Add(this.btnPoker);
            this.Controls.Add(this.label1);
            this.Name = "Casino";
            this.Text = "Welcome to Pelle\'s Casino!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoker;
        private System.Windows.Forms.Button btnGuessCard;
        private System.Windows.Forms.Button btnBlackJack;
        private System.Windows.Forms.Label label1;
    }
}