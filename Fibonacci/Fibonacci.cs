using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciRule
    {

        public static int Fib(int n)
        {
            if (n == 0)
                return 0;
            else if( n <= 2)
                return 1;

            return Fib(n-1) + Fib(n-2);
        }
    }
}
