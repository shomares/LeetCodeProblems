using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IntegerToRomanClass
    {
        /*    1,    'I',
      4,    'IV',
      5,    'V',
      9,    'IX',
     10,    'X',
     40,    'XL',
     50,    'L',
     90,    'XC',
    100,    'C',
    400,    'CD',
    500,    'D',
    900,    'CM',
   1000,    'M'
        */
        private static string ConvertUnitToRoman(int value, int factor)
        {
            if (value == 0) return string.Empty;

            var map = new Dictionary<int, string>() {
                { 1, "I" },
                { 4, "IV"},
                { 5,    "V" },
                { 9,    "IX" },
                { 10,    "X"},
                { 40,    "XL"},
                {50,    "L"},
                {90,    "XC"},
                {100,    "C"},
                {400,    "CD"},
                {500,    "D"},
                {900,    "CM"},
                {1000,    "M"}
            };

            if (map.TryGetValue(value, out string? result))
            {
                return result;
            }

            var resultStr = string.Empty;
            var numIntoFactor = value / factor;

            if (numIntoFactor > 5)
            {
                if (map.TryGetValue(5 * factor, out string? resultS))
                {
                    resultStr = resultS;
                    value -= 5 * factor;
                }
                else
                {
                    return string.Empty;
                }

            }

            if (map.TryGetValue(factor, out var factorOne))
            {
                while (value > 0)
                {
                    resultStr += factorOne;
                    value -= factor;
                }

                return resultStr;
            }

            return resultStr;

        }

        public static string IntToRoman(int num)
        {
            var factor = 10;
            var antFactor = 1;
            var items = new Stack<string>();
            while (num > 0)
            {
                var result = num % factor;
                var resultStr = ConvertUnitToRoman(result, antFactor);
                if (!string.IsNullOrEmpty(resultStr))
                {
                    items.Push(resultStr);
                }

                num -= result;
                antFactor = factor;
                factor *= 10;
            }

            var strBuilder = new StringBuilder();

            while (items.Count > 0)
            {
                strBuilder.Append(items.Pop());
            }

            return strBuilder.ToString();
        }

    }
}
