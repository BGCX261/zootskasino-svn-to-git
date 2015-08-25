using System;

namespace Casino
{
    public class Card : IComparable
    {
        private Rank _rank;
        private Suit _suit;

        public Card(Rank rank, Suit suit)
        {
            _rank = rank;
            _suit = suit;
        }

        public Rank rank { get { return _rank; } }

        public Suit suit { get { return _suit; } }

        public Card PickedCard(Card pickedCard)
        {
            return pickedCard;
        }

        public int CompareToRank(Card o)
        {
            if (o != null)
            {
                Card c = o;
                if (_rank < c.rank)
                    return -1;
                if (_rank > c.rank)
                    return 1;
                return 0;
            }
            throw new ArgumentException("Object is not a Card");
        }

        public int CompareToSuit(Card o)
        {
            if (o != null)
            {
                Card c = o;
                if (_suit < c.suit)
                    return -1;
                if (_suit > c.suit)
                    return 1;
                return 0;
            }
            throw new ArgumentException("Object is not a Card");
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}", _rank, _suit);
        }

        public int CompareTo(object o)
        {
            if (o is Card)
            {
                Card c = (Card)o;
                if (_rank < c.rank)
                    return -1;
                if (_rank > c.rank)
                    return 1;
                return 0;
            }
            throw new ArgumentException("Object is not a Card");
        }

        public bool Equals(Card card)
        {
            //Card thatcard = new Card();
            //thatcard = (Card)obj;

            if (_suit.Equals(card._suit) && _rank.Equals(card._rank))
                return true;
            return false;
        }
    }

    
}
