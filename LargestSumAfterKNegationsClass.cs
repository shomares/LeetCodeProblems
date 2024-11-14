using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LargestSumAfterKNegationsClass
    {
        public int LargestSumAfterKNegations(int[] nums, int k)
        {
            var priorityQueue = new PriorityQueue<int, int>();

            foreach (var item in nums)
            {
                priorityQueue.Enqueue(item, item);
            }

            var index = 0;

            while (index < k)
            {
                var minValue = priorityQueue.Dequeue();
                minValue *= -1;
                priorityQueue.Enqueue(minValue, minValue);
                index++;
            }

            var sum = 0;
            
            while(priorityQueue.Count > 0)
            {
                sum+= priorityQueue.Dequeue();
            }


            return sum;
        }
    }
}
