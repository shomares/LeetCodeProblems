using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LicenseKeyMap
    {
        public static string LicenseKeyFormatting(string s, int k)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }



            var stack = new Stack<char>();
            var grouping = k;
            var index = s.Length - 1;

            while (index >= 0)
            {
                var c = s[index];
                if (c != '-')
                {
                    grouping--;
                    stack.Push(char.ToUpper(c));
                }

                if (grouping == 0)
                {
                    var indexj = index - 1;
                    while (indexj >= 0 && s[indexj] == '-')
                    {
                        indexj--;
                    }

                    if (indexj > -1)
                    {
                        stack.Push('-');
                    }

                    index = indexj + 1;
                    grouping = k;
                }

                index--;
            }

            var result = new StringBuilder();
            while (stack.Count > 0)
            {
                var c = stack.Pop();
                result.Append(c);
            }


            return result.ToString();
        }
    }
}
