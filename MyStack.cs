using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MyStack
    {
        private Queue<int> queue = new();
 

        public MyStack()
        {

        }

        public void Push(int x)
        {
            queue.Enqueue(x);
        }

        public int Pop()
        {
            Queue<int> queueTwo = new();

            while (queue.Count > 1)
            {
                var value = queue.Dequeue();
                queueTwo.Enqueue(value);
            }

            var result = queue.Dequeue();
            queue = queueTwo;
            return result;
        }

        public int Top()
        {
            Queue<int> queueTwo = new();
            int value = 0;

            while (queue.Count > 0)
            {
                value = queue.Dequeue();
                queueTwo.Enqueue(value);
            }

            queue = queueTwo;

            return value;
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}
