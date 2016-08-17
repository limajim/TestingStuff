using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Calculator
{
    public class Keyboard
    {
        private KeyboardType _keyboardType = KeyboardType.Regular;

        public enum KeyboardType { Regular, Scientific};
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
