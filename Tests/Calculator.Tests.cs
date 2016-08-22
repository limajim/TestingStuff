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
            // Set up the mock
            var keyboard = new Mock<IKeyboard>();
            var calculator = new Calculator(keyboard.Object);

            // Act
            // Set what the method should return
            keyboard.Setup(theKeyboard => theKeyboard.GetKeyboardType()).Returns(KeyboardType.Scientific);

            // Assert
            Assert.AreEqual(calculator.GetKeyboard().GetKeyboardType(), KeyboardType.Scientific);
        }

    }
}
