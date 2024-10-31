using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DiStringMatchClass
    {
        public int[] DiStringMatch(string s)
        {
            var i = 0;
            var d = s.Length;

            var firstI = false;
            var firstD = false;

            var result = new int[s.Length + 1];

            var index = 0;

            while (index < s.Length)
            {
                var c = s[index];

                if (c == 'D')
                {
                    result[index] = !firstD ? d : --d;
                    firstD = true;
                }
                else
                {
                    result[index] = !firstI ? i : ++i;
                    firstI = true;
                }

                index++;
            }

            result[index] = s[^1] == 'D' ? --d : ++i;

            return result;


        }
    }
}
