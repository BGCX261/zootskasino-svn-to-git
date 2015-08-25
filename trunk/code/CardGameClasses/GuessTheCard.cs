
namespace Casino
{
    public class GuessTheCard : ICardGame
    {
        private Card _mysteryCard;
        private Card _guessCard;

        public GuessTheCard(Card mysteryCard)
        {
            _mysteryCard = mysteryCard;
        }

        public string CardHints(Card guessCard)
        {
            string guessRank = "";
            string guessSuit = "";

            if (guessCard != null && _mysteryCard != null)
            {
                if (guessCard.rank < _mysteryCard.rank)
                    guessRank = guessCard.rank + " is too low";
                if (guessCard.rank > _mysteryCard.rank)
                    guessRank = guessCard.rank + " is too high";
                if (guessCard.rank == _mysteryCard.rank)
                    guessRank = guessCard.rank + " is correct";
                if (guessCard.suit == _mysteryCard.suit)
                    guessSuit = guessCard.suit + " is correct!";
                if (guessCard.suit != _mysteryCard.suit)
                    guessSuit = guessCard.suit + " is wrong.";
            }
            return guessRank + " and " + guessSuit;
        }

        public Card GuessCard(Card pickedCard)
        {
            _guessCard = pickedCard;

            return _guessCard;
        }

        public int GetSumOfCards()
        {
            int cardSum = 0;

            if(_guessCard.Equals(_mysteryCard)) {
               cardSum = 1;
            }
            return cardSum;
        }

        public bool IsWinner(int sumOfCards)
        {
            bool winner = false;

            if(sumOfCards == 1)
            {
                winner = true;
            }
            return winner;
        }
    }
}
