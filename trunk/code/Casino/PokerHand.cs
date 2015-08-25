using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class PokerHand
    {
        private List<Card> hand = new List<Card>();

        public PokerHand(List<Card> hand)
        {
            this.hand = hand;
        }

        public TypeOfHand GetHandType()
        {
            List<Card> kortLista = new List<Card>();

            int matchRank = 0;
            int matchSuit = 0;
            int pokerHand = 0;

            foreach (Card kort in hand)
                kortLista.Add(kort);

            foreach (Card cardToCompare in kortLista)
            {
                foreach (Card card in hand)
                {
                    if (cardToCompare.CompareToRank(card) == 0)
                        matchRank++;
                    if (cardToCompare.suit == card.suit)
                        matchSuit++;
                    if (matchSuit == 25)
                        pokerHand = matchRank + matchSuit;
                    else
                    {
                        pokerHand = matchRank;
                    }
                }
            }

            switch (pokerHand)
            {
                case 7:
                    return TypeOfHand.Pair;
                case 11:
                    return TypeOfHand.ThreeOfAKind;
                case 17:
                    return TypeOfHand.FourOfAKind;
                case 13:
                    return TypeOfHand.FullHouse;
                case 8:
                    return TypeOfHand.TwoPairs;
                case 30:
                    return TypeOfHand.Flush;
            }
            return TypeOfHand.HighCard;
        }       
    }
}
