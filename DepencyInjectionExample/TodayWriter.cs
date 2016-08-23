using System;
using DepencyInjectionExample.Interfaces;

namespace DepencyInjectionExample
{
    /// <summary>
    /// This implementation of the IOutput interface
    /// is actually how we write to the Console. Technically
    /// we could also implement IOutput to write to Debug
    /// or Trace... or anywhere else.
    /// </summary>
    public class TodayWriter : IDateWriter
    {
        private IOutput _output;
        public TodayWriter(IOutput output)
        {
            this._output = output;
        }

        public void WriteDate()
        {
            this._output.Write(DateTime.Today.ToShortDateString());
        }

    }
}
