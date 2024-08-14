using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NumArray
    {
        private readonly int[] dp;

        public NumArray(int[] nums)
        {
            this.dp = new int[nums.Length];
            dp[0] = nums[0];

            if (nums.Length > 1)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    dp[i] = dp[i - 1] + nums[i];
                }
            }

        }

        public int SumRange(int left, int right)
        {
            if (left == 0)
            {
                return this.dp[right];
            }

            return this.dp[right] - this.dp[left - 1];
        }

    }
}
