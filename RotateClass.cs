using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RotateClass
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length == 1)
            {
                return;
            }

            k %= nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        private void Reverse(int[] nums, int left, int right)
        {
            var index = left;
            var kindex = right;

            while (index <= kindex)
            {
                (nums[index], nums[kindex]) = (nums[kindex], nums[index]);
                index++;
                kindex--;
            }
        }


    }
}
