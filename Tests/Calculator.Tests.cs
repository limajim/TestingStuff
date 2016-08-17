using Microsoft.VisualStudio.TestTools.UnitTesting;
using General.Calculator;
using General.Calculator.Interfaces;
using Moq;


namespace Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Calculator_Add_WhenPassed1And1_Returns2()
        {
            // arrange
            var value1 = 1;
            var value2 = 1;

            // Act
            var total = new Calculator().Add(value1, value2);

            // Assert
            Assert.AreEqual(total, 2);
        }

        [TestMethod]
        public void Calculator_Add_WhenPassed2And1_Returns3()
        {
            // arrange
            var value1 = 1;
            var value2 = 2;

            // Act
            var total = new Calculator().Add(value1, value2);

            // Assert
            Assert.AreEqual(total, 3);
        }

        [TestMethod]
        public void Calculator_Add_When_MOQ()
        {
            // arrange
            var value1 = 1;
            var value2 = 2;


            var mockCalulator = new Mock<ICalculator>();
            


            // Act
            var total = new Calculator().Add(value1, value2);

            // Assert
            Assert.AreEqual(total, 3);
        }

    }
}
