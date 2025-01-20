using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaxProductClass
    {
        public int MaxProduct(int[] nums)
        {
            Array.Sort(nums);
            var maximun = nums[^1];
            var maximunv2 = nums[^2];
            return (maximun - 1) * (maximunv2 - 1);
        }
    }
}
