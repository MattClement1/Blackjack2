namespace Blackjack2CS
{
    partial class frmBlackjack2
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
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYourCards = new System.Windows.Forms.Label();
            this.lblPlayerTotalText = new System.Windows.Forms.Label();
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.btnAdditionalCard = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.lblDealerTotalText = new System.Windows.Forms.Label();
            this.lblDealersCards = new System.Windows.Forms.Label();
            this.picDealerCardThree = new System.Windows.Forms.PictureBox();
            this.picDealerCardTwo = new System.Windows.Forms.PictureBox();
            this.picDealerCardOne = new System.Windows.Forms.PictureBox();
            this.picPlayerCardThree = new System.Windows.Forms.PictureBox();
            this.picPlayerCardTwo = new System.Windows.Forms.PictureBox();
            this.picPlayerCardOne = new System.Windows.Forms.PictureBox();
            this.mnuMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCardThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardOne)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(432, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(152, 22);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.mniNewGame_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblYourCards
            // 
            this.lblYourCards.AutoSize = true;
            this.lblYourCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourCards.Location = new System.Drawing.Point(12, 33);
            this.lblYourCards.Name = "lblYourCards";
            this.lblYourCards.Size = new System.Drawing.Size(78, 16);
            this.lblYourCards.TabIndex = 1;
            this.lblYourCards.Text = "Your Cards:";
            // 
            // lblPlayerTotalText
            // 
            this.lblPlayerTotalText.AutoSize = true;
            this.lblPlayerTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTotalText.Location = new System.Drawing.Point(346, 101);
            this.lblPlayerTotalText.Name = "lblPlayerTotalText";
            this.lblPlayerTotalText.Size = new System.Drawing.Size(42, 16);
            this.lblPlayerTotalText.TabIndex = 5;
            this.lblPlayerTotalText.Text = "Total:";
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTotal.Location = new System.Drawing.Point(394, 101);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(16, 16);
            this.lblPlayerTotal.TabIndex = 6;
            this.lblPlayerTotal.Text = "0";
            // 
            // btnAdditionalCard
            // 
            this.btnAdditionalCard.Enabled = false;
            this.btnAdditionalCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdditionalCard.Location = new System.Drawing.Point(18, 175);
            this.btnAdditionalCard.Name = "btnAdditionalCard";
            this.btnAdditionalCard.Size = new System.Drawing.Size(147, 30);
            this.btnAdditionalCard.TabIndex = 7;
            this.btnAdditionalCard.Text = "Draw Additional Card";
            this.btnAdditionalCard.UseVisualStyleBackColor = true;
            this.btnAdditionalCard.Click += new System.EventHandler(this.btnAdditionalCard_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(171, 175);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(147, 30);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTotal.Location = new System.Drawing.Point(394, 278);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(16, 16);
            this.lblDealerTotal.TabIndex = 14;
            this.lblDealerTotal.Text = "0";
            // 
            // lblDealerTotalText
            // 
            this.lblDealerTotalText.AutoSize = true;
            this.lblDealerTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTotalText.Location = new System.Drawing.Point(346, 278);
            this.lblDealerTotalText.Name = "lblDealerTotalText";
            this.lblDealerTotalText.Size = new System.Drawing.Size(42, 16);
            this.lblDealerTotalText.TabIndex = 13;
            this.lblDealerTotalText.Text = "Total:";
            // 
            // lblDealersCards
            // 
            this.lblDealersCards.AutoSize = true;
            this.lblDealersCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealersCards.Location = new System.Drawing.Point(12, 210);
            this.lblDealersCards.Name = "lblDealersCards";
            this.lblDealersCards.Size = new System.Drawing.Size(101, 16);
            this.lblDealersCards.TabIndex = 9;
            this.lblDealersCards.Text = "Dealer\'s Cards:";
            // 
            // picDealerCardThree
            // 
            this.picDealerCardThree.Image = global::Blackjack2CS.Properties.Resources.Front;
            this.picDealerCardThree.Location = new System.Drawing.Point(224, 229);
            this.picDealerCardThree.Name = "picDealerCardThree";
            this.picDealerCardThree.Size = new System.Drawing.Size(100, 117);
            this.picDealerCardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealerCardThree.TabIndex = 12;
            this.picDealerCardThree.TabStop = false;
            // 
            // picDealerCardTwo
            // 
            this.picDealerCardTwo.Image = global::Blackjack2CS.Properties.Resources.Front;
            this.picDealerCardTwo.Location = new System.Drawing.Point(118, 229);
            this.picDealerCardTwo.Name = "picDealerCardTwo";
            this.picDealerCardTwo.Size = new System.Drawing.Size(100, 117);
            this.picDealerCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealerCardTwo.TabIndex = 11;
            this.picDealerCardTwo.TabStop = false;
            // 
            // picDealerCardOne
            // 
            this.picDealerCardOne.Image = global::Blackjack2CS.Properties.Resources.Front;
            this.picDealerCardOne.Location = new System.Drawing.Point(12, 229);
            this.picDealerCardOne.Name = "picDealerCardOne";
            this.picDealerCardOne.Size = new System.Drawing.Size(100, 117);
            this.picDealerCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealerCardOne.TabIndex = 10;
            this.picDealerCardOne.TabStop = false;
            // 
            // picPlayerCardThree
            // 
            this.picPlayerCardThree.Image = global::Blackjack2CS.Properties.Resources.Front;
            this.picPlayerCardThree.Location = new System.Drawing.Point(224, 52);
            this.picPlayerCardThree.Name = "picPlayerCardThree";
            this.picPlayerCardThree.Size = new System.Drawing.Size(100, 117);
            this.picPlayerCardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerCardThree.TabIndex = 4;
            this.picPlayerCardThree.TabStop = false;
            this.picPlayerCardThree.Visible = false;
            // 
            // picPlayerCardTwo
            // 
            this.picPlayerCardTwo.Image = global::Blackjack2CS.Properties.Resources.Front;
            this.picPlayerCardTwo.Location = new System.Drawing.Point(118, 52);
            this.picPlayerCardTwo.Name = "picPlayerCardTwo";
            this.picPlayerCardTwo.Size = new System.Drawing.Size(100, 117);
            this.picPlayerCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerCardTwo.TabIndex = 3;
            this.picPlayerCardTwo.TabStop = false;
            // 
            // picPlayerCardOne
            // 
            this.picPlayerCardOne.Image = global::Blackjack2CS.Properties.Resources.Front;
            this.picPlayerCardOne.Location = new System.Drawing.Point(12, 52);
            this.picPlayerCardOne.Name = "picPlayerCardOne";
            this.picPlayerCardOne.Size = new System.Drawing.Size(100, 117);
            this.picPlayerCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerCardOne.TabIndex = 2;
            this.picPlayerCardOne.TabStop = false;
            // 
            // frmBlackjack2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 358);
            this.Controls.Add(this.lblDealerTotal);
            this.Controls.Add(this.lblDealerTotalText);
            this.Controls.Add(this.picDealerCardThree);
            this.Controls.Add(this.picDealerCardTwo);
            this.Controls.Add(this.picDealerCardOne);
            this.Controls.Add(this.lblDealersCards);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnAdditionalCard);
            this.Controls.Add(this.lblPlayerTotal);
            this.Controls.Add(this.lblPlayerTotalText);
            this.Controls.Add(this.picPlayerCardThree);
            this.Controls.Add(this.picPlayerCardTwo);
            this.Controls.Add(this.picPlayerCardOne);
            this.Controls.Add(this.lblYourCards);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmBlackjack2";
            this.Text = "Blackjack";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCardThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCardOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblYourCards;
        private System.Windows.Forms.PictureBox picPlayerCardOne;
        private System.Windows.Forms.PictureBox picPlayerCardTwo;
        private System.Windows.Forms.PictureBox picPlayerCardThree;
        private System.Windows.Forms.Label lblPlayerTotalText;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Button btnAdditionalCard;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.Label lblDealerTotalText;
        private System.Windows.Forms.PictureBox picDealerCardThree;
        private System.Windows.Forms.PictureBox picDealerCardTwo;
        private System.Windows.Forms.PictureBox picDealerCardOne;
        private System.Windows.Forms.Label lblDealersCards;
    }
}

