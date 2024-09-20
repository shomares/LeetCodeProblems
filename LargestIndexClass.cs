using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LargestIndexClass
    {
        public static int DominantIndex(int[] nums)
        {
            var max = int.MinValue;
            var maxAnt = int.MinValue;
            var indexMax = -1;

            var index = 0;

            while (index < nums.Length)
            {
                var num = nums[index];

                if (max < num)
                {
                    maxAnt = max;
                    max = num;
                    indexMax = index;
                }
                else
                {
                    if (maxAnt < num)
                    {
                        maxAnt = num;
                    }
                }


                index++;
            }

            if (max == int.MinValue || maxAnt == int.MinValue)
            {
                return -1;
            }

            var doubleValue = maxAnt * 2;


            if (doubleValue <= max)
            {
                return indexMax;
            }

            return -1;

        }

    }
}
