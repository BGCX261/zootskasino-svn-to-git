using System;
using System.Collections;
using System.Collections.Generic;

namespace Casino
{
    public class DeckOfCards : IEnumerable
    {
        private List<Card> _cards;
        private readonly Random _rand = new Random();

        public DeckOfCards()
        {
            _cards = new List<Card>();

            foreach (Suit cardsuit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank cardrank in Enum.GetValues(typeof(Rank)))
                {
                    var card = new Card(cardrank, cardsuit);
                    _cards.Add(card);
                }
            }
        }

        public int Count { get { return _cards.Count; } }

        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();
            while (_cards.Count > 0)
            {
                int cardToMove = _rand.Next(_cards.Count);
                newCards.Add(_cards[cardToMove]);
                _cards.RemoveAt(cardToMove);
            }
            _cards = newCards;
        }


        public List<Card> Deal(int numberOfCards)
        {
            List<Card> dealCards = new List<Card>();

            for (int i = 0; i < numberOfCards; i++)
            {
                dealCards.Add(_cards[i]);
                _cards.Remove(_cards[i]);
            }
            dealCards.Sort();
            return dealCards;
        }

        public void Discard(Card card)
        {
             _cards.Remove(card);
        }  

        public string[] GetCardNames()
        {
            string[] CardNames = new string[_cards.Count];
            for (int i = 0; i < _cards.Count; i++)            
                CardNames[i] = _cards[i].ToString();
            return CardNames;
        }

        public void ResetDeck()
        {
            _cards = new List<Card>();

            foreach (Suit cardsuit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank cardrank in Enum.GetValues(typeof(Rank)))
                {
                    Card card = new Card(cardrank, cardsuit);
                    _cards.Add(card);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return (_cards as IEnumerable).GetEnumerator();

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Card this[int i]
        {
            get { return Card; }
        }

        protected Card Card
        {
            get { return Card; }
            set { Card = value; }
        }
    }
}
