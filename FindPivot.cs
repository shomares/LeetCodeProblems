using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindPivot
    {
        public static int PivotIndex(int[] nums)
        {
            if(nums.Length == 1)
            {
                return 0;
            }

            var sumLeftPrefix = new int[nums.Length];
            var sumRightPrefix = new int[nums.Length];

            var index = 0;

            while (index < nums.Length)
            {

                sumLeftPrefix[index] = (index == 0 ? 0 : sumLeftPrefix[index - 1]) + nums[index];
                sumRightPrefix[^(index + 1)] = (index == 0 ? 0 : sumRightPrefix[^index]) + nums[^(index + 1)];
                index++;
            }

            index = 0;

            int sumLeft;
            int sumRight = sumRightPrefix[1]; 

            while (index < nums.Length)
            {
                if (index == 0)
                {
                    sumLeft = 0;
                }
                else
                {
                    sumLeft = sumLeftPrefix[index - 1];
                }

                if (index == nums.Length - 1)
                {
                    sumRight = 0;
                }
                else if (index > 0)
                {
                    sumRight = sumRightPrefix[index + 1];
                }

                if (sumLeft == sumRight)
                {
                    return index;
                }

                index++;
            }

            return -1;


        }
    }
}
