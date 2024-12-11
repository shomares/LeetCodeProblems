using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindKthLargestClass
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var priority = new PriorityQueue<int, int>();

            foreach (int i in nums)
            {
                priority.Enqueue(i, i);
            }

            var kt = 0;
            var response = 0;
            while (kt <= nums.Length - k)
            {
                response = priority.Dequeue();
                kt++;
            }

            return response;

        }
    }
}
