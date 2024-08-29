using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Harmonious
    {
        public static int FindLHS(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }

            Array.Sort(nums);
            var index = 0;
            var indexj = 0;
            var result = 0;

            while (indexj < nums.Length)
            {
                var numLeft = nums[index];
                var numRight = nums[indexj];

                if (numLeft == numRight)
                {
                    indexj++;
                }
                else if (numRight - numLeft <= 1)
                {
                    result = Math.Max(result, indexj - index + 1);
                    indexj++;
                }
                else
                {
                    while (numRight - numLeft > 1)
                    {
                        numLeft = nums[++index];
                    }

                    if(numLeft != numRight)
                    {
                        result = Math.Max(result, indexj - index + 1);
                    }

                    indexj++;
                }


            }

            return result;
        }
    }
}
