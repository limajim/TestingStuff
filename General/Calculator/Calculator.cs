using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General.Calculator.Interfaces;

namespace General.Calculator
{
    public class Calculator
    {
        private IKeyboard _keyboard;

        public Calculator()
        {
            _keyboard = new Keyboard();

        }

        public Calculator( IKeyboard keyboard)
        {
            _keyboard = keyboard;

        }

        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public IKeyboard GetKeyboard()
        {
            return _keyboard;
        }
    }
}
