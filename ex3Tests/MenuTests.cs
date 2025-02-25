using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WordProcessorTests
{
    [TestClass]
    public class WordProcessorTests
    {
        private WordProcessor _wordProcessor;

        public WordProcessorTests()
        {
            _wordProcessor = new WordProcessor();
        }

        [TestMethod]
        [DataRow("abcdef", true)]
        [DataRow("abc", false)]
        [DataRow("", true)]
        public void IsEvenLength_ReturnsCorrectResult(string word, bool expected)
        {
            // Act
            bool result = _wordProcessor.IsEvenLength(word);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("123456", "214365")]
        [DataRow("abcd", "badc")]
        public void SwapCharacters_SwapsCharactersCorrectly(string word, string expected)
        {
            // Act
            string result = _wordProcessor.SwapCharacters(word);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
