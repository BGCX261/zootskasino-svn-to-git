using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Casino
{
    public partial class GuessTheCard : Form
    {
        private DeckOfCards _deck;
        private DeckOfCards _deckToPick;
        private GuessCard _mysteryCard;

        public GuessTheCard()
        {
            InitializeComponent();
            _deckToPick = new DeckOfCards();
        }

        private void GuessTheCard_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadDeck();
            _deckToPick.Sort();
            DealCard();
        }

        private void cbPickDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuessCard();
        }

        private void StartGame()
        {
            _deck = new DeckOfCards();
            _deck.Shuffle();
            lblDeck.Text = _deck.Count.ToString();
            lblCard.Visible = false;
            lblGuesses.Text = "0";
            lblCardName.Visible = true;
            lblHints.Text = "";
            cbPickDeck.Items.Clear();
        }

        private void LoadDeck()
        {
            cbPickDeck.Items.Clear();
            foreach (string cardName in _deckToPick.GetCardNames())
                cbPickDeck.Items.Add(cardName);
        }

        private void DealCard()
        {
            _deck.Deal(1);

            foreach (string cardName in _deck.GetCardNames())
            {
                lblCard.Text = cardName;
            }
            lblDeck.Text = _deck.Count.ToString();
        }

        private void GuessCard()
        {
            Casino casino = new Casino();
            Card pickedCard = new Card();
            string hintMessage;
            int guesses = int.Parse(lblGuesses.Text);
            
            foreach (Card card in _deck)
                _mysteryCard = new GuessCard(card);

                foreach (Card guessCard in _deckToPick)
                {
                    if (cbPickDeck.SelectedItem.ToString() == guessCard.ToString())
                    {
                        hintMessage = _mysteryCard.CardHints(guessCard);
                        lblHints.Text = hintMessage;
                        pickedCard = guessCard;
                    }
                }
                if (_mysteryCard.IsWinner(pickedCard))
                {
                    lblCard.Visible = true;
                    lblCardName.Visible = false;
                    DialogResult result = MessageBox.Show("You are a winner! \nWould you like to play again?",
                                                           "Guess The Card Result",
                                                          MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes: StartGame();
                            break;
                        case DialogResult.No: casino.Show();
                            break;
                    }
                }
                else if (guesses == 4)
                {
                    lblGuesses.Text = "5";
                    DialogResult result = MessageBox.Show("You are a loser! \nWould you like to play again?",
                                                           "Guess The Card Result",
                                                          MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes: StartGame();
                            break;
                        case DialogResult.No: casino.Show();
                            break;
                    }

                }
                else
                {
                    _deckToPick.Discard(pickedCard);
                    LoadDeck();
                    
                    guesses++;
                    lblGuesses.Text = guesses.ToString();
                }
        }
    }
}
