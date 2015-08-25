using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Casino
{
    public partial class Poker : Form
    {
        readonly DeckOfCards _deck;
        private List<Card> _cards;
        private PokerHand _hand;

        public Poker()
        {
            InitializeComponent();

            _deck = new DeckOfCards();
            _cards = new List<Card>();
            
        }

        private void Casino_Load(object sender, EventArgs e)
        {
            LoadDeck();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            _deck.Shuffle();
            LoadDeck();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            _cards = _deck.Deal(5);
            ShowHand();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _deck.ResetDeck();
            LoadDeck();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lbDeck.Items.Clear();
            _deck.Sort();
            LoadDeck();
        }

        private void LoadDeck()
        {
            lbDeck.Items.Clear();
            lbHand.Items.Clear();
            foreach (string cardName in _deck.GetCardNames())
                lbDeck.Items.Add(cardName);
            label1.Text = "Deck (" + lbDeck.Items.Count + " cards)";
            label2.Text = "Hand (" + lbHand.Items.Count + " cards";
            label3.Text = "";
        }

        private void ShowHand()
        {
            _hand = new PokerHand(_cards);
            lbHand.Items.Clear();
            foreach (Card cardName in _cards)
            {
                lbHand.Items.Add(cardName.ToString());
                lbDeck.Items.Remove(cardName.ToString());
            }
            label2.Text = "Poker Hand (" + _cards.Count + " cards)";
            label1.Text = "Deck (" + _deck.Count + " cards)";
            label3.Text = "You have a " + _hand.GetHandType();
        }
    }
}
