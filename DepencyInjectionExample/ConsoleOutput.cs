using System;
using DepencyInjectionExample.Interfaces;

namespace DepencyInjectionExample
{

    // TODO At Application startup:
    // http://autofac.readthedocs.io/en/latest/getting-started/index.html

    /// <summary>
    /// This implementation of the IOutput interface
    /// is actually how we write to the Console. Technically
    /// we could also implement IOutput to write to Debug
    /// or Trace... or anywhere else.
    /// </summary>
    public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            Console.Write(content);
        }
    }
}
