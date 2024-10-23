using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MinAddToMakeValidClass
    {
        public int MinAddToMakeValid(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var stack = new Stack<char>();
            var missings = 0;

            foreach (char c in s)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        missings++;
                    }

                }
            }


            return stack.Count + missings;
        }
    }
}
