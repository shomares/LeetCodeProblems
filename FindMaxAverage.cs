using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindMaxAverageClass
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            if(k> nums.Length)
            {
                return 0;
            }

            var index = 0;
            var maxSum = 0.0d;
            double currentSum;
            while (index < k)
            {
                maxSum += nums[index++];
            }

            currentSum = maxSum;


            while (index < nums.Length)
            {
                var firstElement = nums[index - k];
                var newElement = nums[index];
                currentSum = currentSum + newElement - firstElement;
                maxSum = Math.Max(currentSum, maxSum);
                index++;

            }

            return maxSum / k;
        }
    }
}
