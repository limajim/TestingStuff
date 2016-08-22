using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Calculator.Interfaces
{

    public enum KeyboardType { Regular, Scientific };

    public interface IKeyboard
    {
        void SetKeyboardType(KeyboardType keyboardType);
        KeyboardType GetKeyboardType();
    }
}
