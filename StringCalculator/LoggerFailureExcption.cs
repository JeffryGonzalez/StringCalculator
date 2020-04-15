using System;

namespace StringCalculator
{
    public class LoggerFailureException : ApplicationException
    {
        public LoggerFailureException(string message): base(message)
        {

        }
    }
}