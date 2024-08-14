using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class ReverseStringClass
    {
        public static void ReverseString(char[] s)
        {
            if (s.Length < 2) return;

            var index = 0;
            var indexJ = s.Length - 1;

            while (index < indexJ)
            {
                (s[indexJ], s[index]) = (s[index], s[indexJ]);
                index++;
                indexJ--;
            }
        }

        private static bool IsVowel(char s) => s == 'a'
               || s == 'e'
               || s == 'i'
               || s == 'o'
               || s == 'u'
               || s == 'A'
               || s == 'E'
               || s == 'I'
               || s == 'O'
               || s == 'U';

        public static string ReverseVowelsAvanced(string s)
        {
            var result = s.ToCharArray();
            var index = 0;
            var indexJ = result.Length - 1;

            while (index < indexJ)
            {
                var charC = result[index];
                var charL = result[indexJ];

                if (IsVowel(charC) && IsVowel(charL))
                {
                    (result[indexJ], result[index]) = (result[index], result[indexJ]);
                    index++;
                    indexJ--;
                }
                else if (IsVowel(charL))
                {
                    index++;
                }
                else if (IsVowel(charC))
                {
                    indexJ--;
                }
                else
                {
                    index++;
                    indexJ--;
                }

            }



            return new string(result);
        }

        public static string ReverseVowels(string s)
        {
            var index = 0;
            var stack = new Stack<char>();
            var result = string.Empty;

            while (index < s.Length)
            {
                var aux = s[index];
                if (IsVowel(aux))
                {
                    stack.Push(aux);
                }
                index++;
            }

            index = 0;

            while (index < s.Length)
            {
                var aux = s[index];

                if (IsVowel(aux))
                {
                    var resultPop = stack.Pop();
                    result += resultPop;
                }
                else
                {
                    result += aux;
                }
                index++;
            }

            return result;

        }
    }
}
