using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;

namespace CardTests
{
    [TestClass]
    public class GuessCardTests
    {
        [TestMethod]
        public void CardHintsString()
        {
            Card guessCard = new Card(Rank.Three, Suit.Spades);
            Card mysteryCard = new Card(Rank.Three, Suit.Spades);
            GuessTheCard card = new GuessTheCard(mysteryCard);


            Assert.AreEqual("Three is correct and Spades is correct!", card.CardHints(guessCard));
        }

        [TestMethod]
        public void GetCardSum()
        {
            Card mysteryCard = new Card(Rank.Two, Suit.Spades);
            Card pickedCard = new Card(Rank.Two, Suit.Spades);
            GuessTheCard guessTheCard = new GuessTheCard(mysteryCard);
            guessTheCard.GuessCard(pickedCard);
            int pickedCardSum = guessTheCard.GetSumOfCards();

            Assert.AreEqual(true, guessTheCard.IsWinner(pickedCardSum));
            
        }
    }
}
