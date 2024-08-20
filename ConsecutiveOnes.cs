using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ConsecutiveOnes
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0] == 1 ? 1 : 0;
            }
            var index = 0;
            var indexj = 1;
            var max = 0;

            while (index < nums.Length && indexj < nums.Length)
            {
                if (nums[index] == 0)
                {
                    index++;
                    indexj++;

                    if (indexj >= nums.Length && nums[index] == 0)
                    {
                        index = indexj;
                    }
                }
                else if (nums[indexj] == 1)
                {
                    indexj++;
                }
                else
                {
                    var diffa = indexj - index;
                    max = Math.Max(max, diffa);
                    index = indexj + 1;

                    if (indexj < nums.Length - 1)
                    {
                        indexj = index + 1;
                    }

                }
            }

            var diff = indexj - index;
            max = Math.Max(max, diff);

            return max;
        }
    }
}
