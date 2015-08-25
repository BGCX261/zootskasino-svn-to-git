using System;
using System.Windows.Forms;
using Casino;

namespace CardGamesForms
{
    public partial class GuessTheCardGame : BaseForm
    {
        private DeckOfCards _deckToPick;
        private GuessTheCard _guessTheCard;
        private Card _mysteryCard;

        public GuessTheCardGame()
        {
            InitializeComponent();
            _deckToPick = new DeckOfCards();
        }

        protected override void StartGame()
        {
            base.StartGame();
            lblGuesses.Text = "0";
            lblDeck.Text = "0";
            lblMysteryCard.Text = "???";
            lblHint.Text = "Hot or Not";
            cbPickDeck.Items.Clear();
        }

        protected override void Deal()
        {
            foreach (Card card in Deck.Deal(1))
            {
                _mysteryCard = new Card(card.rank, card.suit);
            }
            base.Deal();
        }

        protected override void ShowCards()
        {
            cbPickDeck.Items.Clear();
            foreach (string cardName in _deckToPick.GetCardNames())
                cbPickDeck.Items.Add(cardName);
        }

        protected override void IsWinner()
        {
            Card pickedCard = null;
            string hintMessage;
            int guesses = int.Parse(lblGuesses.Text);
            int sumOfPickedCard = 0;
            _guessTheCard = new GuessTheCard(_mysteryCard);

            foreach (Card guessCard in _deckToPick)
            {
                if (cbPickDeck.SelectedItem != null)
                {
                    if (cbPickDeck.SelectedItem.ToString() == guessCard.ToString())
                    {
                        hintMessage = _guessTheCard.CardHints(guessCard);
                        lblHint.Text = hintMessage;
                        pickedCard = _guessTheCard.GuessCard(guessCard);
                        sumOfPickedCard = _guessTheCard.GetSumOfCards();
                    }
                }
            }
            if (_guessTheCard.IsWinner(sumOfPickedCard))
            {
                lblMysteryCard.Text = _mysteryCard.ToString();
                DialogResult result = MessageBox.Show("You are a winner! \nWould you like to play again?",
                                                      "Guess The Card Result",
                                                      MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes: StartGame();
                        break;
                    case DialogResult.No: Close();
                        break;
                }
            }
            else if (guesses == 4)
            {
                lblGuesses.Text = "5";
                lblMysteryCard.Text = _mysteryCard.ToString();
                DialogResult result = MessageBox.Show("You are a loser! \nWould you like to play again?",
                                                      "Guess The Card Result",
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
                _deckToPick.Discard(pickedCard);
                ShowCards();

                guesses++;
                lblGuesses.Text = guesses.ToString();
            }

        }

        private void cbPickDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsWinner();
        }

        private void GuessTheCardGame_Load(object sender, EventArgs e)
        {
            lblNameOfGame.Text = "Guess The Card!";
        }
    }
}
