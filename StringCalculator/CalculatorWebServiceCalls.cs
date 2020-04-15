using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StringCalculator
{
    public class CalculatorWebServiceCalls
    {
        [Fact]
        public void WebServiceIsCalledWhenLoggerThrows()
        {
            var stubbedLogger = new Mock<ILogger>();
            stubbedLogger.Setup(m => m.Write(It.IsAny<string>())).Throws(new LoggerFailureException("Blammo"));
            var mockedWebServer = new Mock<IWebService>();
            var calculator = new Calculator(stubbedLogger.Object, mockedWebServer.Object);

            calculator.Calculate("1");

            mockedWebServer.Verify(m => m.LoggingFailed("Blammo"));


        }
    }
}
