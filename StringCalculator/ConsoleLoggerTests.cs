using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace StringCalculator
{
    public class ConsoleLoggerTests
    {
        [Fact]
        public void LoggerWritesMessageAppropriately()
        {
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);

                var logger = new ConsoleLogger();
                logger.Write("tacos");

                var writtenValue = sw.ToString();
                Assert.Equal("TACOS" + Environment.NewLine, writtenValue);
            }
        }
    }
}
