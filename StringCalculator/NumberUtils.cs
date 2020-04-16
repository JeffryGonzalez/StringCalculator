using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public static class NumberUtils
    {
        public static bool isDelimited(this string numbers)
        {
            return numbers.Contains(',');
        }

        public static bool isEmptyString(this string numbers)
        {
            return numbers == "";
        }
    }
}
