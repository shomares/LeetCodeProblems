using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LastStoneWeightClass
    {
        public int LastStoneWeight(int[] stones)
        {
            var priority = new PriorityQueue<int, int>();
            var max = int.MaxValue;

            foreach (var stone in stones)
            {
                priority.Enqueue(stone, max - stone);
            }

            while (priority.Count > 1)
            {
                var firstMajor = priority.Dequeue();
                var secondMajor = priority.Dequeue();


                if (firstMajor != secondMajor)
                {
                    var newValue = firstMajor - secondMajor ;
                    priority.Enqueue(element: newValue, max - newValue);
                }
            }

            if (priority.Count == 1)
            {
                return priority.Dequeue();
            }

            return 0;
        }
    }
}
