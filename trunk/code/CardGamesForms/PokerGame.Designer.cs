namespace CardGamesForms
{
    partial class PokerGame
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
            this.btnReset = new System.Windows.Forms.Button();
            this.lblHand = new System.Windows.Forms.Label();
            this.lbPokerHand = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lblHand);
            this.panel1.Controls.Add(this.lbPokerHand);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(147, 176);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Deal Again";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblHand
            // 
            this.lblHand.AutoSize = true;
            this.lblHand.Location = new System.Drawing.Point(64, 136);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(35, 13);
            this.lblHand.TabIndex = 4;
            this.lblHand.Text = "label2";
            // 
            // lbPokerHand
            // 
            this.lbPokerHand.FormattingEnabled = true;
            this.lbPokerHand.Location = new System.Drawing.Point(126, 26);
            this.lbPokerHand.Name = "lbPokerHand";
            this.lbPokerHand.Size = new System.Drawing.Size(120, 95);
            this.lbPokerHand.TabIndex = 3;
            // 
            // PokerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(374, 343);
            this.Name = "PokerGame";
            this.Load += new System.EventHandler(this.PokerGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.ListBox lbPokerHand;
    }
}
