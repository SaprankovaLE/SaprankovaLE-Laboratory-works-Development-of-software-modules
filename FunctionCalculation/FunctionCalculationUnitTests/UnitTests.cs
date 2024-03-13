using FunctionCalculationLibrary;
namespace FunctionCalculationUnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestDivideByZeroException()
        {
            Calculations calculator = new Calculations();
            try
            {
                calculator.CalculateFunctionValue(0.1m, 5);
            }
            catch (DivideByZeroException) { Assert.IsTrue(true); }
        }

        [TestMethod]
        public void TestOutOfRangeException()
        {
            Calculations calculator = new Calculations();
            try
            {
                calculator.CalculateFunctionValue(10, -0.5m);
            }
            catch (OverflowException) { Assert.IsTrue(true); }
        }

        [TestMethod]
        public void TestValidInput1()
        {
            Calculations calculator = new Calculations();
            var result = calculator.CalculateFunctionValue(11, 5);
            Assert.AreEqual(-0.1m, result);
        }

        [TestMethod]
        public void TestValidInput2()
        {
            Calculations calculator = new Calculations();
            decimal result = calculator.CalculateFunctionValue(6, 5);
            Assert.AreEqual(-0.18181818m, result, 0.000001m);
        }

        [TestMethod]
        public void TestValidInput3()
        {
            Calculations calculator = new Calculations();
            decimal result = calculator.CalculateFunctionValue(3, 5);
            Assert.AreEqual(-0.357142m, result, 0.000001m);
        }
    }
}