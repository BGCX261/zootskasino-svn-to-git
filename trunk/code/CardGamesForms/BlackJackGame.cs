using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Casino;

namespace CardGamesForms
{
    public partial class BlackJackGame : BaseForm
    {
        private List<Card> _upCards;
        private Card _holeCard;
        private BlackJack _blackjack;

        public BlackJackGame()
        {
            InitializeComponent();
        }

        protected override void StartGame()
        {
            base.StartGame();
            _upCards = new List<Card>();
            _blackjack = new BlackJack(_upCards);
            lbUpCards.Items.Clear();
            lblSumOfCards.Text = "0";
            lblHoleCard.Text = "???";
        }

        protected override void Deal()
        {
            if (lbUpCards.Items.Count == 0)
            {
                List<Card> startCards = new List<Card>();
                startCards = Deck.Deal(2);
                Card[] cards = new Card[2];

                for (int i = 0; i < startCards.Count; i++)
                {
                    cards[i] = startCards[i];
                }

                _upCards.Add(cards[1]);
                _holeCard = new Card(cards[0].rank, cards[0].suit);
                lblHoleCard.Text = cards[0].ToString();
                lblHoleCard.Visible = false;
            }
            else
            {
                foreach (Card card in Deck.Deal(1))
                {
                    _upCards.Add(card);
                }
            }
            base.Deal();
            IsWinner();
        }

        protected override void ShowCards()
        {
            lbUpCards.Items.Clear();
            foreach (Card card in _upCards)
            {
                lbUpCards.Items.Add(card.ToString());
            }
            lblSumOfCards.Text = _blackjack.GetSumOfCards().ToString();
        }

        protected override void IsWinner()
        {
            int sumOfCards = _blackjack.GetSumOfCards();

            if (_blackjack.StopPlaying(sumOfCards))
            {
                lblHoleCard.Visible = true;
                _upCards.Add(_holeCard);
                int newSumOfCards = _blackjack.GetSumOfCards();
                lblSumOfCards.Text = _blackjack.GetSumOfCards().ToString();

                if (_blackjack.IsWinner(newSumOfCards))
                {
                    DialogResult result = MessageBox.Show("Black Jack! \nWould you like to play again?",
                                                          "Black Jack Result",
                                                          MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes: StartGame();
                            break;
                        case DialogResult.No: Close();
                            break;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Busted! \nWould you like to play again?",
                                                          "Black Jack Result",
                                                          MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes: StartGame();
                            break;
                        case DialogResult.No: Close();
                            break;
                    }
                }
            }
        }

        private void BlackJackGame_Load(object sender, EventArgs e)
        {
            lblNameOfGame.Text = "Black Jack";
        }
    }
}
