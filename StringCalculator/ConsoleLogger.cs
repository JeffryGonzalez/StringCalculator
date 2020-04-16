using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class ConsoleLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
    }
}
