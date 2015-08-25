using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Casino
{
    public partial class BlackJackGame : Form
    {
        private DeckOfCards _deck;
        private List<Card> _upCards;
        private Card holeCard;
        private BlackJack _blackjack;

        public BlackJackGame()
        {
            InitializeComponent();
        }

        private void BlackJackGame_Load(object sender, EventArgs e)
        {
            LoadGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
            ShowCards();
            lblDeck.Text = _deck.Count.ToString();
        }

        private void btnHitMe_Click(object sender, EventArgs e)
        {
            HitMe();
            ShowCards();
            lblDeck.Text = _deck.Count.ToString();
            CheckForWinner();
        }

        private void LoadGame()
        {
            _deck = new DeckOfCards();
            _upCards = new List<Card>();
            _blackjack = new BlackJack(_upCards);
            _deck.Shuffle();
            lblDeck.Text = _deck.Count.ToString();
            lbUpCards.Items.Clear();
            lblSum.Text = "0";
            lblHoleCard.Text = "???";
            btnStart.Enabled = true;
            btnHitMe.Enabled = false;
        }

        private void StartGame()
        {
            List<Card> startCards = new List<Card>();
            startCards = _deck.Deal(2);
            Card[] cards = new Card[2];

            for (int i = 0; i < startCards.Count; i++)
            {
                cards[i] = startCards[i];
            }

            _upCards.Add(cards[1]);
            holeCard = new Card(cards[0].rank, cards[0].suit);
            lblHoleCard.Text = cards[0].ToString();
            lblHoleCard.Visible = false;
            btnStart.Enabled = false;
            btnHitMe.Enabled = true;
        }

        private void HitMe()
        {
            foreach (Card card in _deck.Deal(1))
            {
                _upCards.Add(card);
            }
        }

        private void ShowCards()
        {
            lbUpCards.Items.Clear();
            foreach (Card card in _upCards)
            {
                lbUpCards.Items.Add(card.ToString());
            }
            lblSum.Text = _blackjack.GetSumOfCards().ToString();
        }

        private void CheckForWinner()
        {
            Casino casino = new Casino();
            int sumOfCards = _blackjack.GetSumOfCards();

            if (_blackjack.StopPlaying(sumOfCards))
            {
                btnHitMe.Enabled = false;
                lblHoleCard.Visible = true;
                _upCards.Add(holeCard);
                int newSumOfCards = _blackjack.GetSumOfCards();
                lblSum.Text = _blackjack.GetSumOfCards().ToString();

                if (_blackjack.IsWinner(newSumOfCards))
                {
                    DialogResult result = MessageBox.Show("Black Jack! \nWould you like to play again?",
                                                           "Black Jack Result",
                                                          MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes: LoadGame();
                            break;
                        case DialogResult.No: casino.Show();
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
                        case DialogResult.Yes: LoadGame();
                            break;
                        case DialogResult.No: casino.Show();
                            break;
                    }
                }
            }

        }
    }
}
