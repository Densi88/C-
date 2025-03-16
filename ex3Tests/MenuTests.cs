using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WordProcessorTests
{
    [TestClass]
    public class WordProcessorTests
    {
        [TestMethod()]
        public void LeterSwapTest()
        {
            var word = "abcd";
            var result=WordProcessor.SwapCharacters(word);
            Assert.AreEqual("badc", result);
        }
        [TestMethod()]
        public void NumberSwapTest()
        {
            var word = "123456";
            var result = WordProcessor.SwapCharacters(word);
            Assert.AreEqual("214365", result);
        }
        [TestMethod()]
        public void CorrectLenghtOfWordTest() {
            var word = "abcdef";
            var result = WordProcessor.IsEvenLength(word);
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void IncorrectLenghtOfWordTest()
        {
            var word = "abc";
            var result = WordProcessor.IsEvenLength(word);
            Assert.AreEqual(false, result);
        }
    }
}
