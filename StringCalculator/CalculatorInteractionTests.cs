using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StringCalculator
{
    public class CalculatorInteractionTests
    {
        [Theory]
        [InlineData("1,2,3", "6")]
        [InlineData("1,2,3,4,5,6,7,8,9", "45")]
        [InlineData("1", "1")]
        public void AnswersAreLogged(string input, string expected)
        {
            var mockedLogger = new Mock<ILogger>();
            var calculator = new Calculator(mockedLogger.Object, null);

            calculator.Calculate(input);

            mockedLogger.Verify(m => m.Write(expected));

        }
    }
}
