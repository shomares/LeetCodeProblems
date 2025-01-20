using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ShuffleClass
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var result = new int[nums.Length];

            var index = 0;
            var indexk = n;

            var indexR = 0;

            while (indexk < nums.Length)
            {
                result[indexR++] = nums[index++];
                result[indexR++] = nums[indexk++];
            }

            return result;
        }
    }
}
