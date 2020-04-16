using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StringCalculator
{
    public class StringCalculatorTests
    {

        Calculator Calculator;
        public StringCalculatorTests()
        {
            Calculator = new Calculator(new Mock<ILogger>().Object, null); // You big dummy!
        }
        [Fact]
        public void EmptyStringReturnsZero()
        {
            int answer =Calculator.Calculate("");

            Assert.Equal(0, answer);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("42", 42)]
        public void SingleNumber(string numbers, int expected)
        {

            int answer = Calculator.Calculate(numbers);

            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("4,4", 8)]
        [InlineData("10,2", 12)]
        public void CommaSepTwoNumbers(string numbers, int expected)
        {

            int answer = Calculator.Calculate(numbers);
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData("1,2,3,4,5,6,7,8,9", 45)]
        [InlineData("1,2,3", 6)]
        public void Arbitrary(string numbers, int expected)
        {
            int answer = Calculator.Calculate(numbers);
            Assert.Equal(expected, answer);
        }

        
    }
}
