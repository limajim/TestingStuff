using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General.Calculator.Interfaces;

namespace General.Calculator
{
    public class Calculator : ICalculator
    {
        private Keyboard _keyboard;

        public Calculator()
        {
            _keyboard = new Keyboard();

        }

        //https://github.com/moq/moq/blob/master/src/Moq.Sdk.UnitTests/ICalculator.cs
        // Advanced Unit testing part 3 - https://mva.microsoft.com/en-US/training-courses/testdriven-development-16458?l=4Q55WGwXC_9806218965

        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public Keyboard GetKeyboard()
        {
            return _keyboard;
        }
    }
}
