using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    public class Calculator
    {
        

        public int Calculate(string numbers)
        {
            if (numbers.Contains(','))
            {
                return numbers.Split(',')
                     .Select(n => int.Parse(n))
                     .Sum();
            }
            else
            {
                return numbers == "" ? 0 : int.Parse(numbers);
            }
        }
    }
}