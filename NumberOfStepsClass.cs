using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NumberOfStepsClass
    {
        public int NumberOfSteps(int num)
        {
            var steps = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }

                steps++;
            }

            return steps;
        }
    }
}
