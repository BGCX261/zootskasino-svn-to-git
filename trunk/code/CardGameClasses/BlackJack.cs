using System.Collections.Generic;

namespace Casino
{
    public class BlackJack : ICardGame
    {
        private List<Card> hand = new List<Card>();

        public BlackJack(List<Card> hand)
        {
            this.hand = hand;
        }

        public int GetSumOfCards()
        {
            int sumOfCards = 0;
            int numberCards = 0;
            int faceCards = 0;
            int isAce = 0;
            foreach (Card card in hand)
            {
                if (card.rank != Rank.Ace)
                {
                    if (10 < (int) card.rank)
                    {
                        faceCards += 10;
                    }
                    else if (10 >= (int) card.rank)
                    {
                        numberCards += (int) card.rank;
                    }
                    sumOfCards = faceCards + numberCards;
                }
                else
                {
                    isAce++;
                }
            }

            if (isAce != 0)
            {
                if (isAce > 1)
                {
                    int[] aces = new int[isAce];

                    if (sumOfCards > 10)
                        aces[0] = 1;
                    else
                    {
                        aces[0] = 11;
                    }
                    sumOfCards += isAce - 1;
                    sumOfCards += aces[0];
                }
                else
                {
                    if (sumOfCards > 10)
                        isAce = 1;
                    else
                    {
                        isAce = 11;
                    }
                    sumOfCards += isAce;
                }
            }
            return sumOfCards;
        }
        
        public bool StopPlaying(int sumOfCards)
        {
            bool stop;

            if (sumOfCards >= 17)
                stop = true;
            else
            {
                stop = false;
            }
            return stop;
        }

        public bool IsWinner(int sumOfCards)
        {
            bool winner;

            if(sumOfCards == 21)
                winner = true;
            else
            {
                winner = false;
            }
            return winner;
        }
    }
}
