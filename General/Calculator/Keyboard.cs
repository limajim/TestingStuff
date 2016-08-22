using General.Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Calculator
{
    public class Keyboard : IKeyboard
    {
        private KeyboardType _keyboardType = KeyboardType.Regular;

        public void SetKeyboardType( KeyboardType keyboardType )
        {
            _keyboardType = keyboardType;
        }

        public KeyboardType GetKeyboardType()
        {
            return _keyboardType ;
        }
    }
}
