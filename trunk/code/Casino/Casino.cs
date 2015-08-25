using System;
using System.Windows.Forms;
using CardGamesForms;

namespace Casino
{
    public partial class Casino : Form
    {

        public Casino()
        {
            InitializeComponent();
        }

        private void btnPoker_Click(object sender, EventArgs e)
        {
            PokerGame poker = new PokerGame();
            poker.Show();
        }

        private void btnGuessCard_Click(object sender, EventArgs e)
        {
            GuessTheCardGame guessTheCard = new GuessTheCardGame();
            guessTheCard.Show();
        }

        private void btnBlackJack_Click(object sender, EventArgs e)
        {
           BlackJackGame blackJack = new BlackJackGame();
           blackJack.Show();
        }
    }
}
