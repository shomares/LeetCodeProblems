using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class GreddySum
    {
        public static int ArrayPairSum(int[] nums)
        {
            if (nums.Length % 2 != 0)
            {
                return -1;
            }
            Array.Sort(nums);
            var result = 0;

            for (var index = 1; index < nums.Length; index += 2)
            {
                var ant = nums[index - 1];
                var curr = nums[index];

                var min = Math.Min(curr, ant);
                result += min;

            }

            return result;
        }
    }
}
