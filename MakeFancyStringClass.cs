using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MakeFancyStringClass
    {
        public string MakeFancyString(string s)
        {
            var result = new StringBuilder();

            var index = 0;
            var countS = 0;
            char? ant = null;

            while (index < s.Length)
            {
                var c = s[index];

                ant ??= c;

                if (ant == c)
                {
                    countS++;
                }
                else
                {
                    countS = 1;
                }

                if(countS < 3)
                {
                    result.Append(c);
                }

                ant = c;

                index++;
            }


            return result.ToString();
        }
    }
}
