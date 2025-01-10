using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountNegativesClass
    {
        public int CountNegatives(int[][] grid)
        {
            var sum = 0;
            foreach (int[] row in grid)
            {
                sum += CountNegativesInRow(row);
            }

            return sum;
        }


        private int CountNegativesInRow(int[] row)
        {
            if (row[0] <= -1)
            {
                return row.Length;
            }

            var left = 0;
            var right = row.Length - 1;


            while (left < right)
            {
                var middle = left + (right - left) / 2;
                var toEvaluate = row[middle];
                if (toEvaluate > -1)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            if (row[left] <= -1)
            {
                return row.Length - left;
            }

            if (left + 1 < row.Length && row[left + 1] <= -1)
            {
                return row.Length - (left + 1);
            }

            return 0;
        }
    }
}
