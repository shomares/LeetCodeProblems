using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MinOperationsClass
    {
        public int MinOperations(string[] logs)
        {
            var stack = 0;

            var index = 0;

            while (index < logs.Length)
            {
                var step = logs[index];

                if (step == "../")
                {
                    stack = stack == 0 ? stack : stack - 1;
                }
                else if (step != "./")
                {
                    stack++;
                }

                index++;
            }

            return stack;
        }
    }
}
