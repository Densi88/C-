using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DepositTests
{
    [TestClass]
    public class DepositLogicTests
    {
        [TestMethod()]
        public void depositIncreaseTest()
        {
            var deposit = 1000;
            var increase = 20;
            var result=DepositLogic.CalculateIncrease(deposit, increase);
            Assert.AreEqual(5, result);
        }
        [TestMethod()]
        public void TargetLogicTest() {
            var deposit = 80;
            var target = 70;
            var result = DepositLogic.CalculateMonthsForTarget(80, 70);
            Assert.AreEqual(0, result);
        }
        [TestMethod()]
        public void CorrectMonthReturn()
        {
            var monthNumber = 5;
            var increase = 20;
            var result = Menu.DisplayMonth(monthNumber, 20);
            Assert.AreEqual("Прирост к вкладу стал больше чем 20 в мае", result);
        }

    }
}
