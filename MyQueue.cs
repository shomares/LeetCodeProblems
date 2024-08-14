using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MyQueue
    {
        private readonly Stack<int> stack = new();
        int? indexToReturn;
        bool flag = false;
        public MyQueue()
        {

        }

        public void Push(int x)
        {
            stack.Push(x);

        }

        private int PopRecursive()
        {
            var index = stack.Pop();

            if (stack.Count == 0)
            {
                indexToReturn = index;
                flag= true;
                return index;
            }

            var newValue = PopRecursive();

            if (!flag)
            {
                stack.Push(newValue);
            }
            else
            {
                flag = false;
            }

            return index;

        }

        private int PeekRecursive()
        {
            var index = stack.Pop();

            if (stack.Count == 0)
            {
                indexToReturn = index;
                return index;
            }

            var newValue = PeekRecursive();
            stack.Push(newValue);
            return index;

        }


        public int Pop()
        {
            indexToReturn = null;
            var top = PopRecursive();

            if (!flag)
            {
                stack.Push(top);
            }
            return indexToReturn.Value;
        }

        public int Peek()
        {
            indexToReturn = null;
            var top = PeekRecursive();
            stack.Push(top);
            return indexToReturn.Value;
        }

        public bool Empty()
        {
            return stack.Count == 0;
        }
    }
}
