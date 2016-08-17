using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci;


namespace Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void Fib_Given0_Return0()
        {
            int number = 0;
            int result = FibonacciRule.Fib(number);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Fib_Given1_Return1()
        {
            int number = 1;
            int result = FibonacciRule.Fib(number);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Fib_Given2_Return2()
        {
            int number = 2;
            int result = FibonacciRule.Fib(number);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Fib_Given4_Return3()
        {
            int number = 4;
            int result = FibonacciRule.Fib(number);
            Assert.AreEqual(3, result);
        }


    }
}
