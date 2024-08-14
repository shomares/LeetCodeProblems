using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SearchInsertClass
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1, mid = 0;

            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == target)
                    return mid;

                if (nums[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }


            if (nums[mid] > target)
            {
                return mid;
            }

            if (mid + 1 >= nums.Length)
            {
                return mid + 1;
            }

            if (nums[mid + 1] > target)
            {
                return mid + 1;
            }

            return mid;

        }
    }
}
