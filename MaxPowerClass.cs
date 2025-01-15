using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaxPowerClass
    {
        public int MaxPower(string s = "cc")
        {
            var index = 0;
            char? ant = null;
            var maxSize = int.MinValue;
            var currentSize = 1;

            while (index < s.Length)
            {
                var current = s[index];
                if (ant == null || ant != current)
                {
                    maxSize = Math.Max(maxSize, currentSize);
                    currentSize = 1;
                }
                else
                {
                    currentSize++;
                }

                ant = current;

                index++;
            }

            maxSize = Math.Max(maxSize, currentSize);


            return maxSize;
        }
    }
}
