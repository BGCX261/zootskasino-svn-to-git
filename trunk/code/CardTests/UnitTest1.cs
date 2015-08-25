using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;

namespace CardTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DealCards()
        {
            DeckOfCards deck = new DeckOfCards();
            Assert.AreEqual(52, deck.Count);

            deck.Deal(5);
            Assert.AreEqual(5, deck.Count);
           
            deck.ResetDeck();
            Assert.AreEqual(52, deck.Count);
        }

        [TestMethod]
        public void PokerHand()
        {
            //DeckOfCards deck = new DeckOfCards();
            //deck.Deal(5);
            //PokerHand hand = new PokerHand(deck);

            //Assert.AreEqual(5, hand.GetNumberOfCards());
        }
    }
}
