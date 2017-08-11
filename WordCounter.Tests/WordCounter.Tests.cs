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

    }
}