using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SearchInRange
    {
        private static int FindRight(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var result = -1;

            while (left <= right)
            {
                var middle = (left + right) / 2;
                var valueMiddle = nums[middle];

                if (valueMiddle == target)
                {
                    result = middle;
                    left = middle + 1;
                    right = nums.Length - 1;
                }
                else if (valueMiddle < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }

            }

            return result;
        }

        private static int FindLeft(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var result = -1;

            while (left <= right)
            {
                var middle = (left + right) / 2;
                var valueMiddle = nums[middle];

                if (valueMiddle == target)
                {
                    result = middle;
                    right = middle - 1;
                    left = 0;
                }
                else if (valueMiddle < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }

            }

            return result;
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            var result = new int[2] { -1, -1 };

            var left = FindLeft(nums, target);
        
            if (left == -1)
            {
                return result;
            }

            var right = FindRight(nums, target);

            result[0] = left;
            result[1] = right;


            return result;
        }
    }
}
