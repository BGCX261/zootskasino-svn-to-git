using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;

namespace CardTests
{
    [TestClass]
    public class BlackJackTests
    {
        [TestMethod]
        public void TestAce()
        {
            List<Card> upCards = new List<Card>()
                                  {
                                      new Card(Rank.Ace, Suit.Spades),
                                      new Card(Rank.Four, Suit.Hearts),
                                      new Card(Rank.Three, Suit.Clubs),
                                      new Card(Rank.Jack, Suit.Spades),
                                      new Card(Rank.Two, Suit.Spades)
                                  };
            BlackJack blackJack = new BlackJack(upCards);

            Assert.AreEqual(20, blackJack.GetSumOfCards());
        }
        
        [TestMethod]
        public void UpHoleCards()
        {
            List<Card> cards = new List<Card>()
                                  {
                                      new Card(Rank.Three, Suit.Spades),
                                      new Card(Rank.Five, Suit.Hearts),
                                  };
            Card[] hand = new Card[2];

            for (int i = 0; i < cards.Count; i++)
            {
                hand[i] = cards[i];
            }

            Card upCard = hand[0];
            Card holeCard = hand[1];

            Assert.AreEqual("Three of Spades", upCard.ToString());
            Assert.AreEqual("Five of Hearts", holeCard.ToString());
        }

        [TestMethod]
        public void GetSumOfCards()
        {
            List<Card> cards = new List<Card>()
                                  {
                                      new Card(Rank.Three, Suit.Spades),
                                      new Card(Rank.Three, Suit.Spades),
                                      new Card(Rank.Ace, Suit.Hearts),
                                      new Card(Rank.Ace, Suit.Hearts)
                                  };
            BlackJack blackJack = new BlackJack(cards);

            Assert.AreEqual(18, blackJack.GetSumOfCards());
        }

        [TestMethod]
        public void GetWinner()
        {
            List<Card> cards = new List<Card>
                                   {
                                       new Card(Rank.Ace, Suit.Spades),
                                       new Card(Rank.King, Suit.Spades)
                                   };
            BlackJack blackJack = new BlackJack(cards);

            int sumOfCards = blackJack.GetSumOfCards();

            Assert.AreEqual(true, blackJack.IsWinner(sumOfCards));
        }
    }
}
