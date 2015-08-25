using System;
using System.Windows.Forms;
using Casino;

namespace CardGamesForms
{
    public partial class BaseForm : Form
    {
        protected DeckOfCards Deck;

        public BaseForm()
        {
            InitializeComponent();
        }

        protected virtual void StartGame()
        {
            Deck = new DeckOfCards();
            Deck.Shuffle();
            lblDeck.Text = Deck.Count.ToString();
            btnDeal.Enabled = true;
            btnStart.Enabled = false;
        }

        protected virtual void Deal()
        {
            lblDeck.Text = Deck.Count.ToString();
            ShowCards();
        }

        protected virtual void ShowCards()
        {

        }

        protected virtual void IsWinner()
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            Deal();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            btnDeal.Enabled = false;
            btnStart.Enabled = true;
        }
    }
}
