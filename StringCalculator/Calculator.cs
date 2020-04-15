using System;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    public class Calculator
    {
        

        public int Calculate(string numbers)
        {
            if (numbers.Contains(','))
            {
                var regex = new Regex(@"(\d+),(\d+)");
                var groups = regex.Matches(numbers)[0];
                var num1 = int.Parse(groups.Groups[1].Value);
                var num2 = int.Parse(groups.Groups[2].Value);
                return num1 + num2;
            }
            else
            {
                return numbers == "" ? 0 : int.Parse(numbers);
            }
        }
    }
}