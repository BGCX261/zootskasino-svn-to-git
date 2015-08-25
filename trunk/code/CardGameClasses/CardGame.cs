using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Casino
{
    public abstract class CardGame
    {
        private List<Card> _cards;

        public CardGame(List<Card> cards)
        {
            _cards = cards;
        }

        public virtual bool IsWinner()
        {
            return false;
        }
    }
}
