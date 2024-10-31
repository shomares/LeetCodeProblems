using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MinDeletionSizeClass
    {
        public int MinDeletionSize(string[] strs)
        {
            var index = 0;
            var result = 0;
            while (index < strs[0].Length)
            {

                char? aux = null;
                char current;

                var indexj = 0;

                while (indexj < strs.Length)
                {
                    current = strs[indexj][index];

                    if (aux != null && current < aux)
                    {
                        result++;
                        break;
                    }

                    aux = current;
                    indexj++;
                }

                index++;

            }


            return result;
        }
    }
}
