using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseOnlyLettersClass
    {
        public string ReverseOnlyLetters(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            var left = 0;
            var right = s.Length - 1;

            var chars = s.ToCharArray();

            while (left <= right)
            {
                var cL = chars[left];
                var cR = chars[right];

                if (char.IsLetter(cL) && char.IsLetter(cR))
                {
                    (chars[left], chars[right]) = (chars[right], chars[left]);
                    left++;
                    right--;
                }

                else if (!char.IsLetter(cL))
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return new string(chars);

        }
    }
}
