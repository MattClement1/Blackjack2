using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack2CS
{
    public partial class frmBlackjack2 : Form
    {
        int[] cardArray = new int[52];
        int playerTotal;
        Random rndCard = new Random();

        public int FlipCard(ref PictureBox picBox, int cardValue)
        {
            int totalValue = 0;

            if (cardValue == 0 && cardArray[0] == 1)
            {
                picBox.Image = Properties.Resources.AS;
                cardArray[0] = 0;
                totalValue = 1;
            }
            else if (cardValue == 1 && cardArray[1] == 1)
            {
                picBox.Image = Properties.Resources.AC;
                cardArray[1] = 0;
                totalValue = 1;
            }
            else if (cardValue == 2 && cardArray[2] == 1)
            {
                picBox.Image = Properties.Resources.AH;
                cardArray[2] = 0;
                totalValue = 1;
            }
            else if (cardValue == 3 && cardArray[3] == 1)
            {
                picBox.Image = Properties.Resources.AD;
                cardArray[3] = 0;
                totalValue = 1;
            }
            else if (cardValue == 4 && cardArray[4] == 1)
            {
                picBox.Image = Properties.Resources._2S;
                cardArray[4] = 0;
                totalValue = 2;
            }
            else if (cardValue == 5 && cardArray[5] == 1)
            {
                picBox.Image = Properties.Resources._2C;
                cardArray[5] = 0;
                totalValue = 2;
            }
            else if (cardValue == 6 && cardArray[6] == 1)
            {
                picBox.Image = Properties.Resources._2H;
                cardArray[6] = 0;
                totalValue = 2;
            }
            else if (cardValue == 7 && cardArray[7] == 1)
            {
                picBox.Image = Properties.Resources._2D;
                cardArray[7] = 0;
                totalValue = 2;
            }
            else if (cardValue == 8 && cardArray[8] == 1)
            {
                picBox.Image = Properties.Resources._3S;
                cardArray[8] = 0;
                totalValue = 3;
            }
            else if (cardValue == 9 && cardArray[9] == 1)
            {
                picBox.Image = Properties.Resources._3C;
                cardArray[9] = 0;
                totalValue = 3;
            }
            else if (cardValue == 10 && cardArray[10] == 1)
            {
                picBox.Image = Properties.Resources._3H;
                cardArray[10] = 0;
                totalValue = 3;
            }
            else if (cardValue == 11 && cardArray[11] == 1)
            {
                picBox.Image = Properties.Resources._3D;
                cardArray[11] = 0;
                totalValue = 3;
            }
            else if (cardValue == 12 && cardArray[12] == 1)
            {
                picBox.Image = Properties.Resources._4S;
                cardArray[12] = 0;
                totalValue = 4;
            }
            else if (cardValue == 13 && cardArray[13] == 1)
            {
                picBox.Image = Properties.Resources._4C;
                cardArray[13] = 0;
                totalValue = 4;
            }
            else if (cardValue == 14 && cardArray[14] == 1)
            {
                picBox.Image = Properties.Resources._4H;
                cardArray[14] = 0;
                totalValue = 4;
            }
            else if (cardValue == 15 && cardArray[15] == 1)
            {
                picBox.Image = Properties.Resources._4D;
                cardArray[15] = 0;
                totalValue = 4;
            }
            else if (cardValue == 16 && cardArray[16] == 1)
            {
                picBox.Image = Properties.Resources._5S;
                cardArray[16] = 0;
                totalValue = 5;
            }
            else if (cardValue == 17 && cardArray[17] == 1)
            {
                picBox.Image = Properties.Resources._5C;
                cardArray[17] = 0;
                totalValue = 5;
            }
            else if (cardValue == 18 && cardArray[18] == 1)
            {
                picBox.Image = Properties.Resources._5H;
                cardArray[18] = 0;
                totalValue = 5;
            }
            else if (cardValue == 19 && cardArray[19] == 1)
            {
                picBox.Image = Properties.Resources._5D;
                cardArray[19] = 0;
                totalValue = 5;
            }
            else if (cardValue == 20 && cardArray[20] == 1)
            {
                picBox.Image = Properties.Resources._6S;
                cardArray[20] = 0;
                totalValue = 6;
            }
            else if (cardValue == 21 && cardArray[21] == 1)
            {
                picBox.Image = Properties.Resources._6C;
                cardArray[21] = 0;
                totalValue = 6;
            }
            else if (cardValue == 22 && cardArray[22] == 1)
            {
                picBox.Image = Properties.Resources._6H;
                cardArray[22] = 0;
                totalValue = 6;
            }
            else if (cardValue == 23 && cardArray[23] == 1)
            {
                picBox.Image = Properties.Resources._6D;
                cardArray[23] = 0;
                totalValue = 6;
            }
            else if (cardValue == 24 && cardArray[24] == 1)
            {
                picBox.Image = Properties.Resources._7S;
                cardArray[24] = 0;
                totalValue = 7;
            }
            else if (cardValue == 25 && cardArray[25] == 1)
            {
                picBox.Image = Properties.Resources._7C;
                cardArray[25] = 0;
                totalValue = 7;
            }
            else if (cardValue == 26 && cardArray[26] == 1)
            {
                picBox.Image = Properties.Resources._7H;
                cardArray[26] = 0;
                totalValue = 7;
            }
            else if (cardValue == 27 && cardArray[27] == 1)
            {
                picBox.Image = Properties.Resources._7D;
                cardArray[27] = 0;
                totalValue = 7;
            }
            else if (cardValue == 28 && cardArray[28] == 1)
            {
                picBox.Image = Properties.Resources._8S;
                cardArray[28] = 0;
                totalValue = 8;
            }
            else if (cardValue == 29 && cardArray[29] == 1)
            {
                picBox.Image = Properties.Resources._8C;
                cardArray[29] = 0;
                totalValue = 8;
            }
            else if (cardValue == 30 && cardArray[30] == 1)
            {
                picBox.Image = Properties.Resources._8H;
                cardArray[30] = 0;
                totalValue = 8;
            }
            else if (cardValue == 31 && cardArray[31] == 1)
            {
                picBox.Image = Properties.Resources._8D;
                cardArray[31] = 0;
                totalValue = 8;
            }
            else if (cardValue == 32 && cardArray[32] == 1)
            {
                picBox.Image = Properties.Resources._9S;
                cardArray[32] = 0;
                totalValue = 9;
            }
            else if (cardValue == 33 && cardArray[33] == 1)
            {
                picBox.Image = Properties.Resources._9C;
                cardArray[33] = 0;
                totalValue = 9;
            }
            else if (cardValue == 34 && cardArray[34] == 1)
            {
                picBox.Image = Properties.Resources._9H;
                cardArray[34] = 0;
                totalValue = 9;
            }
            else if (cardValue == 35 && cardArray[35] == 1)
            {
                picBox.Image = Properties.Resources._9D;
                cardArray[35] = 0;
                totalValue = 9;
            }
            else if (cardValue == 36 && cardArray[36] == 1)
            {
                picBox.Image = Properties.Resources._10S;
                cardArray[36] = 0;
                totalValue = 10;
            }
            else if (cardValue == 37 && cardArray[37] == 1)
            {
                picBox.Image = Properties.Resources._10C;
                cardArray[37] = 0;
                totalValue = 10;
            }
            else if (cardValue == 38 && cardArray[38] == 1)
            {
                picBox.Image = Properties.Resources._10H;
                cardArray[38] = 0;
                totalValue = 10;
            }
            else if (cardValue == 39 && cardArray[39] == 1)
            {
                picBox.Image = Properties.Resources._10D;
                cardArray[39] = 0;
                totalValue = 10;
            }
            else if (cardValue == 40 && cardArray[40] == 1)
            {
                picBox.Image = Properties.Resources.JS;
                cardArray[40] = 0;
                totalValue = 10;
            }
            else if (cardValue == 41 && cardArray[41] == 1)
            {
                picBox.Image = Properties.Resources.JC;
                cardArray[41] = 0;
                totalValue = 10;
            }
            else if (cardValue == 42 && cardArray[42] == 1)
            {
                picBox.Image = Properties.Resources.JH;
                cardArray[42] = 0;
                totalValue = 10;
            }
            else if (cardValue == 43 && cardArray[43] == 1)
            {
                picBox.Image = Properties.Resources.JD;
                cardArray[43] = 0;
                totalValue = 10;
            }
            else if (cardValue == 44 && cardArray[44] == 1)
            {
                picBox.Image = Properties.Resources.QS;
                cardArray[44] = 0;
                totalValue = 10;
            }
            else if (cardValue == 45 && cardArray[45] == 1)
            {
                picBox.Image = Properties.Resources.QC;
                cardArray[45] = 0;
                totalValue = 10;
            }
            else if (cardValue == 46 && cardArray[46] == 1)
            {
                picBox.Image = Properties.Resources.QH;
                cardArray[46] = 0;
                totalValue = 10;
            }
            else if (cardValue == 47 && cardArray[47] == 1)
            {
                picBox.Image = Properties.Resources.QD;
                cardArray[47] = 0;
                totalValue = 10;
            }
            else if (cardValue == 48 && cardArray[48] == 1)
            {
                picBox.Image = Properties.Resources.KS;
                cardArray[48] = 0;
                totalValue = 10;
            }
            else if (cardValue == 49 && cardArray[49] == 1)
            {
                picBox.Image = Properties.Resources.KC;
                cardArray[49] = 0;
                totalValue = 10;
            }
            else if (cardValue == 50 && cardArray[50] == 1)
            {
                picBox.Image = Properties.Resources.KH;
                cardArray[50] = 0;
                totalValue = 10;
            }
            else if (cardValue == 51 && cardArray[51] == 1)
            {
                picBox.Image = Properties.Resources.JS;
                cardArray[51] = 0;
                totalValue = 10;
            }

            return totalValue;
        }

        public frmBlackjack2()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mniNewGame_Click(object sender, EventArgs e)
        {
            this.picDealerCardThree.Image = Properties.Resources.Front;
            this.picDealerCardTwo.Image = Properties.Resources.Front;
            this.picDealerCardOne.Image = Properties.Resources.Front;
            this.picPlayerCardThree.Image = Properties.Resources.Front;
            this.picPlayerCardThree.Visible = false;
            this.btnAdditionalCard.Enabled = true;
            this.btnCheck.Enabled = true;

            int cardOneTotal = 0;
            int cardTwoTotal = 0;
            
            playerTotal = 0;                      

            for (int counter = 0; counter <= 51; counter++)
            {
                cardArray[counter] = 1;
            }

            while (cardOneTotal == 0)
            {
                int cardOne = rndCard.Next(0, 51 + 1);
                cardOneTotal = FlipCard(ref this.picPlayerCardOne, cardOne);
                playerTotal = playerTotal + cardOneTotal;
            }
            while (cardTwoTotal == 0)
            {
                int cardTwo = rndCard.Next(0, 51 + 1);
                cardTwoTotal = FlipCard(ref this.picPlayerCardTwo, cardTwo);
                playerTotal = playerTotal + cardTwoTotal;
            }

            this.lblPlayerTotal.Text = Convert.ToString(playerTotal);
        }

        private void btnAdditionalCard_Click(object sender, EventArgs e)
        {
            this.picPlayerCardThree.Visible = true;
            this.btnAdditionalCard.Enabled = true;

            int cardThreeTotal = 0;

            while (cardThreeTotal == 0)
            {
                int cardThree = rndCard.Next(0, 51 + 1);
                cardThreeTotal = FlipCard(ref this.picPlayerCardThree, cardThree);
                playerTotal = playerTotal + cardThreeTotal;
            }

            this.lblPlayerTotal.Text = Convert.ToString(playerTotal);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.btnAdditionalCard.Enabled = false;
            this.btnCheck.Enabled = false;

            int dCardOneTotal = 0;
            int dCardTwoTotal = 0;
            int dCardThreeTotal = 0;
            int dealerTotal = 0;

            while (dCardOneTotal == 0)
            {
                int dCardOne = rndCard.Next(1, 51 + 1);
                dCardOneTotal = FlipCard(ref this.picDealerCardOne, dCardOne);
                dealerTotal = dealerTotal + dCardOneTotal;
            }
            while (dCardTwoTotal == 0)
            {
                int dCardTwo = rndCard.Next(1, 51 + 1);
                dCardTwoTotal = FlipCard(ref this.picDealerCardTwo, dCardTwo);
                dealerTotal = dealerTotal + dCardTwoTotal;
            }
            while (dCardThreeTotal == 0)
            {
                int dCardThree = rndCard.Next(1, 51 + 1);
                dCardThreeTotal = FlipCard(ref picDealerCardThree, dCardThree);
                dealerTotal = dealerTotal + dCardThreeTotal;                 
            }

            this.lblDealerTotal.Text = Convert.ToString(dealerTotal);

            if (playerTotal > dealerTotal && playerTotal <= 21)
            {
                MessageBox.Show("You Win!" + Environment.NewLine + "Your Total: " + playerTotal + Environment.NewLine + "Dealer's Total: " + dealerTotal);
            }
            else if (dealerTotal > 21 && playerTotal <=21)
            {
                MessageBox.Show("You Win!" + Environment.NewLine + "Your Total: " + playerTotal + Environment.NewLine + "Dealer's Total: " + dealerTotal);
            }
            else if (dealerTotal > playerTotal && dealerTotal <=21)
            {
                MessageBox.Show("You Lose!" + Environment.NewLine + "Your Total: " + playerTotal + Environment.NewLine + "Dealer's Total: " + dealerTotal);
            }
            else if (playerTotal > 21 && dealerTotal <= 21)
            {
                MessageBox.Show("You Lose!" + Environment.NewLine + "Your Total: " + playerTotal + Environment.NewLine + "Dealer's Total: " + dealerTotal);
            }
            else
            {
                MessageBox.Show("Draw!" + Environment.NewLine + "Your Total: " + playerTotal + Environment.NewLine + "Dealer's Total: " + dealerTotal);
            }
        }
    }
}
