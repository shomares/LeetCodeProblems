using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SortStringClass
    {
        public string SortString(string s)
        {
            var dictionary = new int[27];
            var str = new StringBuilder();

            var index = 0;

            while (index < s.Length)
            {
                var c = s[index];
                dictionary[c - 97] = dictionary[c - 97] + 1;
                index++;
            }

            var toRight = true;
            while (str.Length < s.Length)
            {
                var key = toRight ? 0 : 26;

                while ((toRight && key <= 26) || (!toRight && key >= 0))
                {
                    if (dictionary[key] > 0)
                    {
                        str.Append((char)(key + 97));
                        dictionary[key] = dictionary[key] - 1;
                    }

                    key = toRight ? key + 1 : key - 1;
                }

                toRight = !toRight;
            }


            return str.ToString();
        }
    }
}
