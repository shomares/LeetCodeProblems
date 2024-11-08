using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DividePlayersClass
    {
        public long DividePlayers(int[] skill)
        {
            var result = 0L;
            Array.Sort(skill);

            int? sumDivide = null;

            var index = 0;
            var indexj = skill.Length - 1;

            while (index < indexj)
            {
                var left = skill[index];
                var right = skill[indexj];

                var sum = left + right;

                if (sumDivide == null || sum == sumDivide)
                {
                    sumDivide = sum;
                    result += left * right;
                }
                else
                {
                    return -1;
                }

                index++;
                indexj--;
            }

            return result;
        }
    }
}
