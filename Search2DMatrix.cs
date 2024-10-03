using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Search2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var columns = matrix[0].Length;
            var rows = matrix.Length;

            var right = columns * rows;
            var left = 0;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                var index = GenerateIndex(middle, columns);

                if (index.Item1 >= rows || index.Item2 >= columns)
                {
                    return false;
                }

                var value = matrix[index.Item1][index.Item2];

                if (value == target)
                {
                    return true;
                }
                else if (value > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return false;

        }


        private Tuple<int, int> GenerateIndex(int pos, int n)
        {
            return Tuple.Create(pos / n, pos % n);

        }
    }
}
