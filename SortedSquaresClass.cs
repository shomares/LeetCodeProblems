using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SortedSquaresClass
    {
        public int[] SortedSquares(int[] nums)
        {
    

            var index = 0;
            var indexj = nums.Length - 1;
            int j = nums.Length - 1;
            var result = new int[indexj +1 ];

            while (index <= indexj)
            {
                var left = Math.Abs(nums[index]);
                var right = Math.Abs(nums[indexj]);

                if (left > right)
                {
                    result[j] = left * left;
                    index++;
                }
                else
                {
                    result[j] = right * right;
                    indexj--;
                }

                j--;

            }


            return result;
        }
    }
}
