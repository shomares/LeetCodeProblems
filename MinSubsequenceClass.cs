using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MinSubsequenceClass
    {
        //[4,4,7,6,7]
        public IList<int> MinSubsequence(int[] nums)
        {
            var result = new List<int>();

            var sum = nums.Sum();

            var sumRight = 0;

            Array.Sort(nums);

            var index = nums.Length - 1;

            while (index >= 0)
            {
                var item = nums[index];
                sumRight += item;
                sum -= item;
                result.Add(item);
                if (sumRight > sum)
                {
                    break;
                }

                index--;
            }


            return result;
        }
    }
}
