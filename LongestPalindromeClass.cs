using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LongestPalindromeClass
    {
        public static int LongestPalindrome(string s = "ababababa")
        {
            var hashmap = new Dictionary<char, int>();

            foreach (var c in s)
            {
                if (hashmap.TryGetValue(c, out int value))
                {
                    hashmap[c] = ++value;
                }
                else
                {
                    hashmap.Add(c, 1);
                }
            }

            var onlyOneNumber = false;
            var result = 0;

            if (hashmap.Count == 1)
            {
                return hashmap[s[0]];
            }

            foreach (var dic in hashmap)
            {
                var key = dic.Key;
                var value = dic.Value;

                if (value % 2 != 0 && !onlyOneNumber)
                {
                    result += value;
                    onlyOneNumber = true;
                }
                else if (value % 2 == 0)
                {
                    result += value;
                }
                else
                {
                    result += value - 1;
                }
            }

            return result;

        }
    }
}
