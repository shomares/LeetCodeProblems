using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MultiplyClass
    {
        public static string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
            {
                return "0";
            }

            var cache = Array.Empty<int>();
            var index = num1.Length - 1;
            var factor = 0;

            while (index >= 0)
            {
                var charRow = new int[num2.Length + factor + 1];
                var factorx = (int)char.GetNumericValue(num1[index]);
                var indexj = num2.Length - 1;
                var carry = 0;
                var factorInt = charRow.Length - 1 - factor;
                var indexCharCop = charRow.Length - 1;

                for (var indexk = cache.Length - 1; indexk > cache.Length - 1 - factor; indexk--)
                {
                    charRow[indexCharCop] = cache[indexk];
                    indexCharCop--;
                }

                while (indexj >= 0)
                {
                    var factory = (int)char.GetNumericValue(num2[indexj]);
                    var resultDigit = (factorx * factory) +
                            (cache.Length > 0 && factorInt - 1 >= 0 ? cache[factorInt - 1] : 0) + carry;
                    var valueToInsert = resultDigit % 10;
                    carry = resultDigit / 10;
                    charRow[factorInt] = valueToInsert;
                    indexj--;
                    factorInt--;
                }

                while (carry > 0)
                {
                    charRow[0] = carry;
                    carry /= 10;
                }

                cache = charRow;
                factor++;
                index--;
            }

            index = cache[0] == 0 ? 1 : 0;

            var str = new StringBuilder();
            while (index < cache.Length)
            {
                str.Append(cache[index]);
                index++;
            }

            return str.ToString();
        }
    }
}
