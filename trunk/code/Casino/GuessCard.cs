using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Casino
{
    public class GuessCard
    {
        private Card mysteryCard;
        private Card guessCard;
        private List<Card> _discardedCards;

        public GuessCard(Card mysteryCard)
        {
            this.mysteryCard = mysteryCard;
        }

        public string CardHints(Card pickedCard)
        {
            guessCard = pickedCard;
            string guessRank = "";
            string guessSuit = "";

            if (guessCard != null && mysteryCard != null)
            {
                if (guessCard.rank < mysteryCard.rank)
                    guessRank = guessCard.rank + " is too low";
                if (guessCard.rank > mysteryCard.rank)
                    guessRank = guessCard.rank + " is too high";
                if (guessCard.rank == mysteryCard.rank)
                    guessRank = guessCard.rank + " is correct";
                if (guessCard.suit == mysteryCard.suit)
                    guessSuit = guessCard.suit + " is correct!";
                if (guessCard.suit != mysteryCard.suit)
                    guessSuit = guessCard.suit + " is wrong.";
            }
            return guessRank + " and " + guessSuit;
        }

        public bool IsWinner(Card pickCard)
        {
            guessCard = pickCard;
            bool winner = false;
                if (guessCard.Equals(mysteryCard))
                  winner = true;
            return winner;
        }

        public void WrongGuesses(Card pickedCard)
        {
            List<Card> wrongGuesses = new List<Card>();
            guessCard = pickedCard;

            if (guessCard != mysteryCard)
            {
                wrongGuesses.Add(guessCard);
            }
            _discardedCards = wrongGuesses;
        }
    }
}
