using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RunningSumClass
    {
        public int[] RunningSum(int[] nums)
        {
            var result = new int[nums.Length];

            var index = 0;

            while (index < nums.Length)
            {
                result[index] = nums[index] + (index == 0 ? 0 : result[index - 1]);
                index++;
            }

            return result;
        }
    }
}
