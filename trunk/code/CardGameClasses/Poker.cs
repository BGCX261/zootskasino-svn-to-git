using System;
using System.Collections.Generic;

namespace Casino
{
    public class Poker : ICardGame
    {
        private List<Card> _hand = new List<Card>();

        public Poker(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsFlush()
        {
            bool isFlush = false;
            int matchSuit = 0;
            List<Card> compareHand = new List<Card>();

            foreach (Card kort in _hand)
                compareHand.Add(kort);

            foreach (Card card in _hand)
            {
                foreach (Card cardToCompare in compareHand)
                {
                    if (card.CompareToSuit(cardToCompare) == 0)
                        matchSuit++;
                }
            }
            if (matchSuit == 25)
                isFlush = true;
         
            return isFlush;
        }

        public bool IsStraight()
        {
            bool isStraight = false;
            Card[] straightHand = new Card[5];

            for (int i = 0; i < _hand.Count; i++)
            {
                straightHand[i] = _hand[i];
            }
            Array.Sort(straightHand);

            if (straightHand[0].rank == straightHand[1].rank - 1 &&
                straightHand[1].rank == straightHand[2].rank - 1 &&
                straightHand[2].rank == straightHand[3].rank - 1 &&
                straightHand[3].rank == straightHand[4].rank - 1)
                isStraight = true;

            return isStraight;
        }

        public bool IsRoyalFlush()
        {
            bool isRoyalFlush = false;
            Card[] straightRoyal = new Card[5];

            if (IsFlush())
            {
                for (int i = 0; i < _hand.Count; i++)
                {
                    straightRoyal[i] = _hand[i];
                }
                Array.Sort(straightRoyal);

                if (straightRoyal[1].rank == Rank.Ten &&
                    straightRoyal[2].rank == Rank.Jack &&
                    straightRoyal[3].rank == Rank.Queen &&
                    straightRoyal[4].rank == Rank.King &&
                    straightRoyal[0].rank == Rank.Ace)
                    isRoyalFlush = true;
            }

            return isRoyalFlush;
        }

        public int GetSumOfCards()
        {
            int matchRank = 0;
            int pokerHand = 0;
            List<Card> compareHand = new List<Card>();

            if(IsFlush() && IsStraight())
                pokerHand = 37;
            else if(IsStraight())
                pokerHand = 12;
            else if (IsRoyalFlush())
                pokerHand = 39;
            else if (IsFlush())
                pokerHand = 25;
            else
            {
                foreach (Card kort in _hand)
                    compareHand.Add(kort);

                foreach (Card cardToCompare in compareHand)
                {
                    foreach (Card card in _hand)
                    {
                        if (cardToCompare.CompareToRank(card) == 0)
                            matchRank++;
                            pokerHand = matchRank;
                    }
                }
                if (pokerHand == 13)
                    pokerHand = 30;
                if (pokerHand == 17)
                    pokerHand = 35;
            }
            return pokerHand;
        }

        public TypeOfHand GetHandType(int pokerHand)
        {
            switch (pokerHand)
            {
                case 39:
                    return TypeOfHand.RoyalFlush;
                case 37:
                    return TypeOfHand.StraightFlush;
                case 35:
                    return TypeOfHand.FourOfAKind;
                case 30:
                    return TypeOfHand.FullHouse;
                case 25:
                    return TypeOfHand.Flush;
                case 12:
                    return TypeOfHand.Straight;
                case 11:
                    return TypeOfHand.ThreeOfAKind;
                case 9:
                    return TypeOfHand.TwoPairs;
                case 7:
                    return TypeOfHand.Pair;
            }
            return TypeOfHand.HighCard;
        }
       
        public bool IsWinner(int sumOfCards)
        {
            return false;
        }
    }
}
