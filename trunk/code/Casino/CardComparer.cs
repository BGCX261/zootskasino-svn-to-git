using System.Collections.Generic;

namespace Casino
{
    public class CardComparer : IComparer<Card>
    {
        public enum SortCriteria
        {
            ByRank,
            BySuit
        }

        public SortCriteria SortBy = SortCriteria.BySuit;

        public int Compare(Card x, Card y)
        {
            switch (SortBy)
            {
                case SortCriteria.BySuit:
                    if (x.suit < y.suit)
                        return -1;
                    if (x.suit > y.suit)
                        return 1;
                    if (x.rank < y.rank)
                        return -1;
                    if (x.rank > y.rank)
                        return 1;
                    return 0;
                default:
                    if (x.rank < y.rank)
                        return -1;
                    if (x.rank > y.rank)
                        return 1;
                    if (x.suit < y.suit)
                        return -1;
                    if (x.suit > y.suit)
                        return 1;
                    return 0;
            }
        }
    }
}
