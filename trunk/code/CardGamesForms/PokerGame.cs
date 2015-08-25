using System;
using System.Collections.Generic;
using Casino;

namespace CardGamesForms
{
    public partial class PokerGame : BaseForm
    {
        private List<Card> _cards;
        private Poker _hand;

        public PokerGame()
        {
            InitializeComponent();

            _cards = new List<Card>();
        }

        protected override void StartGame()
        {
            base.StartGame();
            lbPokerHand.Items.Clear();
            lblHand.Text = "";
            btnReset.Enabled = true;
        }

        protected override void Deal()
        {
            _cards = Deck.Deal(5);
            base.Deal();
        }

        protected override void ShowCards()
        {
            _hand = new Poker(_cards);
            lbPokerHand.Items.Clear();
            foreach (Card cardName in _cards)
            {
                lbPokerHand.Items.Add(cardName.ToString());
            }
            int sumOfHand = _hand.GetSumOfCards();
            lblHand.Text = "You have a " + _hand.GetHandType(sumOfHand);
        }

        private void PokerGame_Load(object sender, EventArgs e)
        {
            lblNameOfGame.Text = "Pelle's Poker";
            btnReset.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Deck.ResetDeck();
            StartGame();
            Deal();
        }
    }
}
