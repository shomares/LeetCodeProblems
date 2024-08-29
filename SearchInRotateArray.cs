using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class SearchInRotateArray
    {
        private static int GetPivot(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;
                var numInMiddle = nums[middle];
                if (numInMiddle > nums[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return left;
        }

        public static int Search(int[] nums, int target)
        {
            var pivot = GetPivot(nums);

            int left;
            int rigth;

            if (nums[pivot] == target)
            {
                return pivot;
            }


            if (pivot == 0)
            {
                left = 0;
                rigth = nums.Length - 1;
            }
            else
            {
                if (target <= nums[pivot - 1] && target >= nums[0])
                {
                    left = 0;
                    rigth = pivot - 1;
                }
                else
                {
                    left = pivot + 1;
                    rigth = nums.Length - 1;
                }

            }



            while (left <= rigth)
            {
                var middle = (left + rigth) / 2;
                var numInMiddle = nums[middle];

                if (numInMiddle == target)
                {
                    return middle;
                }

                if (numInMiddle < target)
                {
                    left = middle + 1;
                }
                else
                {
                    rigth = middle - 1;
                }
            }

            return -1;
        }
    }
}
