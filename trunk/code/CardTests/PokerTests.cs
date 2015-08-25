using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;

namespace CardTests
{
    [TestClass]
    public class PokerTests
    {
        [TestMethod]
        public void DealCards()
        {
            DeckOfCards deck = new DeckOfCards();
            Assert.AreEqual(52, deck.Count);

            deck.Deal(5);
            Assert.AreEqual(47, deck.Count);
           
            deck.ResetDeck();
            Assert.AreEqual(52, deck.Count);
        }

        [TestMethod]
        public void CardsToCompare()
        {
            Card card1 = new Card(Rank.Jack, Suit.Spades);
            Card card2 = new Card(Rank.Jack, Suit.Spades);

            Assert.AreEqual(0, card1.CompareToRank(card2));
        }

        [TestMethod]
        public void GetHandSum()
        {
            List<Card> hand = new List<Card>()
                                  {
                                      new Card(Rank.Ace, Suit.Spades),
                                      new Card(Rank.Ace, Suit.Clubs),
                                      new Card(Rank.Ace, Suit.Hearts),
                                      new Card(Rank.Five, Suit.Diamonds),
                                      new Card(Rank.Five, Suit.Clubs)
                                  };
            Poker pokerHand = new Poker(hand);
            int getHandSum = pokerHand.GetSumOfCards();
    
            Assert.AreEqual(30, getHandSum);
        }

        [TestMethod]
        public void GetHandType()
        {
            List<Card> hand = new List<Card>()
                                  {
                                      new Card(Rank.Ten, Suit.Spades),
                                      new Card(Rank.Ten, Suit.Diamonds),
                                      new Card(Rank.Ten, Suit.Clubs),
                                      new Card(Rank.Ten, Suit.Hearts),
                                      new Card(Rank.Six, Suit.Clubs)
                                  };
            Poker pokerHand = new Poker(hand);
            int getHandSum = pokerHand.GetSumOfCards();
            
            Assert.AreEqual(TypeOfHand.FourOfAKind, pokerHand.GetHandType(getHandSum));
        }

        [TestMethod]
        public void StraightHand()
        {
            List<Card> hand = new List<Card>()
                                  {
                                      new Card(Rank.Three, Suit.Clubs),
                                      new Card(Rank.Two, Suit.Hearts),
                                      new Card(Rank.Ace, Suit.Spades),
                                      new Card(Rank.Four, Suit.Diamonds),
                                      new Card(Rank.Five, Suit.Spades)
                                  };
            Poker pokerHand = new Poker(hand);

            Assert.AreEqual(true, pokerHand.IsStraight());
        }

        [TestMethod]
        public void IsFlush()
        {
            List<Card> hand = new List<Card>()
                                  {
                                      new Card(Rank.Three, Suit.Clubs),
                                      new Card(Rank.Two, Suit.Clubs),
                                      new Card(Rank.Ace, Suit.Clubs),
                                      new Card(Rank.Four, Suit.Clubs),
                                      new Card(Rank.Five, Suit.Clubs)
                                  };
            Poker pokerHand = new Poker(hand);

            Assert.AreEqual(true, pokerHand.IsFlush());
        }

        [TestMethod]
        public void IsRoyalFlush()
        {
            List<Card> hand = new List<Card>()
                                  {
                                      new Card(Rank.Ten, Suit.Clubs),
                                      new Card(Rank.King, Suit.Clubs),
                                      new Card(Rank.Ace, Suit.Clubs),
                                      new Card(Rank.Jack, Suit.Clubs),
                                      new Card(Rank.Queen, Suit.Clubs)
                                  };
            Poker pokerHand = new Poker(hand);

            Assert.AreEqual(true, pokerHand.IsRoyalFlush());
        }
    }
}
