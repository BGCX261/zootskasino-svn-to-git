using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Casino
{
    public class BlackJackClass
    {
        private Rank rankAce;
        private Suit suit;
        private DeckOfCards cardList = new DeckOfCards();
        public int AceValue(int sumOfCards)
        {
            rankAce = 1;
            if (sumOfCards == 10)
               rankAce  = 11;
        }
    }
}
