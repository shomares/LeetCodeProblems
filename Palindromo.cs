using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Palindromo
    {

        public static bool IsPalindrome(string s)
        {
            var index = 0;
            var indexj = s.Length - 1;
            char value, toco;

            while (index <= indexj)
            {
                value = char.ToLower(s[index]);
                toco = char.ToLower(s[indexj]);

                while (index + 1 < s.Length && !char.IsLetterOrDigit(value))
                {
                    value = s[++index];
                }
                while (indexj > 0 && !char.IsLetterOrDigit(toco))
                {
                    toco = s[--indexj];
                }


                if (char.IsLetterOrDigit(value) && char.IsLetterOrDigit(toco) && char.ToLower(value) != char.ToLower(toco))
                {
                    return false;
                }

                index++;
                indexj--;

            }

            return true;
        }

        public static bool IsPalindromeInt(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var valueStr = x.ToString();

            for (var index = 0; index < valueStr.Length; index++)
            {
                var charX = valueStr[index];
                var charJ = valueStr[^(index + 1)];

                if (charX != charJ)
                {
                    return false;
                }

            }

            return true;
        }
    }
}
