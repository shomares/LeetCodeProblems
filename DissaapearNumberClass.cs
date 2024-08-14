using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DissaapearNumberClass
    {

        private static int ExistsElementBinarySearch(int target, int[] source, int low, int high)
        {
            int mid;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (source[mid] == target)
                {
                    return mid;
                }

                if (source[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;

        }

        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            var result = new List<int>();
            Array.Sort(nums);
            var index = 0;
            int current, shoulbe = 1;
            while (shoulbe - 1 < nums.Length && index < nums.Length)
            {
                current = nums[index];

                if (current != shoulbe)
                {
                    var existsItem = ExistsElementBinarySearch(shoulbe, nums, index, nums.Length - 1);

                    if (existsItem != -1)
                    {
                        (nums[existsItem], nums[index]) = (nums[index], nums[existsItem]);
                    }
                    else
                    {
                        if (current > shoulbe)
                        {
                            index--;
                        }

                        result.Add(shoulbe);
                    }
                }

                index++;
                shoulbe++;


            }


            return result;
        }
    }
}
