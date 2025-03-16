using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tests
{
    [TestClass()]
    public class CurrencyProcessorTests
    {
        [TestMethod()]

        public void KopeykiTest()
        {
            var kopeyki = 2;
            var result=CurrencyProcessor.ProcessCurrency(kopeyki);
            Assert.AreEqual("0 рублей 2 копейки", result);
        }
        [TestMethod()]
        public void KopeykaTest() {
            var kopeyki = 1;
            var result = CurrencyProcessor.ProcessCurrency(kopeyki);
            Assert.AreEqual("0 рублей 1 копейка", result);
        }
        [TestMethod()]
        public void KopeekTest() { 
            var kopeyki = 99;
            var result = CurrencyProcessor.ProcessCurrency(kopeyki);
            Assert.AreEqual("0 рублей 99 копеек", result);
        }
        [TestMethod()]
        public void rublTest()
        {
            var kopeyki = 100;
            var result = CurrencyProcessor.ProcessCurrency(kopeyki);
            Assert.AreEqual("1 рубль 0 копеек", result);
        }
        [TestMethod()]
        public void rublyaTest() {
            var kopeyki = 200;
            var result = CurrencyProcessor.ProcessCurrency(kopeyki);
            Assert.AreEqual("2 рубля 0 копеек", result);
        }
        [TestMethod()]
        public void rubleyTest() {
            var kopeyki = 500;
            var result = CurrencyProcessor.ProcessCurrency(kopeyki);
            Assert.AreEqual("5 рублей 0 копеек", result);
        }

    }
   
}
