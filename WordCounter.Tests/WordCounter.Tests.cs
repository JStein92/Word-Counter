using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void IsWordContained_ReturnTrueIfWordisContainedInSentence_True()
        {
            //Arrange
            RepeatCounter testCounter = new RepeatCounter("This is a test", "test");
            bool expected = true;
            //Act
            bool actual = testCounter.IsWordContained();
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void CountRepeats_ReturnAmountOfWordsInSentence_True()
        {
            //Arrange
            RepeatCounter testCounter = new RepeatCounter("This is a test", "test");
            int expected = 4;
            //Act
            int actual = testCounter.CountRepeats();
            //Assert
            Assert.AreEqual(expected,actual);
        }

    }
}