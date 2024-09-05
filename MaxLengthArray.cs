using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaxLengthArray
    {

        public static int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 1;
            }

            var index = 0;
            var indexj = 1;
            var maxLengtAux = 1;
            var maxLength = int.MinValue;

            while (indexj < nums.Length)
            {
                var value = nums[index];
                var valueTCompare = nums[indexj];

                if (valueTCompare > value)
                {
                    maxLengtAux++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, maxLengtAux);
                    maxLengtAux = 1;
                }

                index++;
                indexj++;
            }


            return Math.Max(maxLength, maxLengtAux);
        }
    }
}
