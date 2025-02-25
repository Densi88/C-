using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tests
{
    [TestClass()]
    public class CurrencyProcessorTests
    {
        private readonly CurrencyProcessor _currencyProcessor;

        public CurrencyProcessorTests()
        {
            _currencyProcessor = new CurrencyProcessor();
        }

        [TestMethod]
        [DataRow(1, "копейка")]
        [DataRow(2, "копейки")]
        [DataRow(5, "копеек")]
        [DataRow(99, "копеек")]
        public void GetKopeykiWord_ReturnsCorrectWord(int numberOfKopeyki, string expected)
        {
            // Act
            string result = _currencyProcessor.GetKopeykiWord(numberOfKopeyki);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1, "рубль")]
        [DataRow(2, "рубля")]
        [DataRow(5, "рублей")]
        [DataRow(10, "рублей")]
        [DataRow(99, "рублей")]
        public void GetRublesWord_ReturnsCorrectWord(int integerRubles, string expected)
        {
            // Act
            string result = _currencyProcessor.GetRublesWord(integerRubles);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ProcessCurrency_InvalidInput_ReturnsErrorMessage()
        {
            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _currencyProcessor.ProcessCurrency(-5);
                string result = sw.ToString();

                // Assert
                Assert.IsTrue(result.Contains("Некоректный ввод"));
            }
        }

        [TestMethod]
        [DataRow(1234, "12 рублей 34 копейки")]
        [DataRow(100, "1 рубль 0 копеек")]
        [DataRow(1000, "10 рублей 0 копеек")]
        [DataRow(0, "0 рублей 0 копеек")]
        public void ProcessCurrency_ValidInput_ReturnsCorrectOutput(int input, string expectedOutput)
        {
            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _currencyProcessor.ProcessCurrency(input);
                string result = sw.ToString();

                // Assert
                Assert.IsTrue(result.Contains(expectedOutput));
            }
        }
    }
}
