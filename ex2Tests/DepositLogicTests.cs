using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DepositTests
{
    [TestClass]
    public class DepositLogicTests
    {
        private DepositLogic _depositLogic;

        public DepositLogicTests()
        {
            _depositLogic = new DepositLogic();
        }

        [TestMethod]
        [DataRow(1000, 20, 5)]  // Пример: депозит 1000, прирост больше 20 в 5-м месяце
        [DataRow(5000, 100, 5)]  // Пример: депозит 5000, прирост больше 100 в 5-м месяце
        [DataRow(200, 10, 3)]    // Пример: депозит 200, прирост больше 10 в 3-м месяце
        public void CalculateIncrease_ReturnsCorrectMonth(double deposit, double firstNumber, int expectedMonth)
        {
            // Act
            int result = _depositLogic.CalculateIncrease(deposit, firstNumber);

            // Assert
            Assert.AreEqual(expectedMonth, result);
        }

        [TestMethod]
        [DataRow(100, 102, 2)]  // Пример: депозит 100, цель 102, требуется 2 месяца
        [DataRow(1000, 1020, 2)]  // Пример: депозит 1000, цель 1020, требуется 2 месяца
        [DataRow(100, 80, 0)]    // Пример: депозит 100, цель 80, требуется 0 месяцев
        public void CalculateMonthsForTarget_ReturnsCorrectMonths(double startDeposit, double targetAmount, int expectedMonths)
        {
            // Act
            int result = _depositLogic.CalculateMonthsForTarget(startDeposit, targetAmount);

            // Assert
            Assert.AreEqual(expectedMonths, result);
        }
    }
}
