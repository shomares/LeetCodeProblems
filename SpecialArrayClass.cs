using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SpecialArrayClass
    {
        public int SpecialArray(int[] nums)
        {
            Array.Sort(nums);

            var index = 1;
            var maximun = nums[^1];

            while (index <= maximun)
            {
                var calculated = CalculateMaxItemsOf(nums, index);

                if (calculated)
                {
                    return index;
                }

                index++;
            }

            return -1;

        }

        private bool CalculateMaxItemsOf(int[] nums, int index)
        {
            var left = 0;
            var righ = nums.Length - 1;
            var result = -1;

            while (left <= righ)
            {
                var middle = left + (righ - left) / 2;
                var valueA = nums[middle];

                if (valueA == index)
                {

                    if (middle > 0 && nums[middle - 1] == index)
                    {
                        righ = middle - 1;
                        continue;
                    }

                    result = middle;
                    break;
                }
                else if (valueA > index)
                {
                    righ = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            if (result != -1)
            {
                return (nums.Length - result) == index;
            }

            var value = nums[left];

            if (value > index)
            {
                return (nums.Length - left) == index;
            }

            while (left < nums.Length && nums[left] < index)
            {
                left++;
            }

            return (nums.Length - left) == index;
        }
    }
}
