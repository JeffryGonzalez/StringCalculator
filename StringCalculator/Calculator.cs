using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    public class Calculator
    {
        private ILogger Logger;

        public Calculator(ILogger logger)
        {
            this.Logger = logger;
        }

        public int Calculate(string numbers)
        {
            int answer = 0;
            if (numbers.Contains(','))
            {
                answer = numbers.Split(',')
                     .Select(n => int.Parse(n))
                     .Sum();
            }
            else
            {
                answer = numbers == "" ? 0 : int.Parse(numbers);
            }
            Logger.Write(answer.ToString());
            return answer;
        }
    }
}