using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MinStartValueClass
    {
        public int MinStartValue(int[] nums)
        {
            var sum = 0;
            var minValue = 0;

            foreach( var item in nums )
            {
                sum += item;
                minValue = Math.Min(minValue, sum);
            }

            return 1 - minValue;

        }
    }
}
