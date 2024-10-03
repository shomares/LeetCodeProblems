using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SortColorsClass
    {

        public void SortColors(int[] nums)
        {
            var lo = 0;
            var hi = nums.Length - 1;
            var mid = 0;

            while (mid <= hi)
            {
                if (nums[mid] == 0)
                {
                    (nums[lo], nums[mid]) = (nums[mid], nums[lo]);
                    mid++;
                    lo++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    (nums[mid], nums[hi]) = (nums[hi], nums[mid]);
                    hi--;
                }
            }

        }
    }
}
