using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PhoneCombinations
    {
        private static List<string> result = [];
        private readonly static Dictionary<char, string> keyboard = new()
        {
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" }
            };


        private static string Calculate(string carry, string digits, int index)
        {
            if (index >= digits.Length)
            {
                return carry;
            }

            var charValue = digits[index];
            var str = keyboard[charValue];
            foreach (var x in str)
            {
                var finalString = Calculate(carry + x, digits, index + 1);

                if (index == digits.Length - 1)
                {
                    result.Add(finalString);
                }
            }

            return str;
        }

        public static IList<string> LetterCombinations(string digits)
        {
            result = [];

            if (string.IsNullOrEmpty(digits))
            {
                return result;
            }
            Calculate(string.Empty, digits, 0);
            return result;
        }


    }
}
