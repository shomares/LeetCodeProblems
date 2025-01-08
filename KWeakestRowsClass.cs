using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class KWeakestRowsClass
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            var result = new int[k];
            var priority = new PriorityQueue<int, double>();

            var index = 0;

            while (index < mat.Length)
            {
                var indexj = 0;
                var strong = 0;

                while (indexj < mat[index].Length)
                {
                    if (mat[index][indexj] == 1)
                    {
                        strong++;
                    }

                    indexj++;
                }

                priority.Enqueue(index, strong + (index * .005));

                index++;
            }

            index = 0;

            while (index < k)
            {
                result[index] = priority.Dequeue();
                index++;
            }

            return result;
        }
    }
}
