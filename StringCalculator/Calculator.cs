using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    public class Calculator
    {
        private ILogger Logger;
        private IWebService WebService;

        public Calculator(ILogger logger, IWebService webService)
        {
            Logger = logger;
            WebService = webService;
        }

        public int Calculate(string numbers)
        {
            if (numbers.isEmptyString()) { return 0; }

            int answer = 0;
            if (numbers.isDelimited())
            {
                answer = numbers.Split(',')
                     .Select(n => int.Parse(n))
                     .Sum();
            }
            else
            {
                answer = int.Parse(numbers);
            }
            try
            {
                Logger.Write(answer.ToString());
            }
            catch (LoggerFailureException ex)
            {

                WebService.LoggingFailed(ex.Message);
            }
            return answer;
        }


    }
}