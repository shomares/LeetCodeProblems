using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaximunProductClass
    {
        public static int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            var lastProduct = nums[^1] * nums[^2] * nums[^3];
            var lastProductLeft = nums[^1] * nums[0] * nums[1];
            return Math.Max(lastProductLeft, lastProduct);

        }
    }
}
