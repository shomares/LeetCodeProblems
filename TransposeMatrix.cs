using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TransposeMatrix
    {
        public int[][] Transpose(int[][] matrix)
        {
            var result = new int[matrix[0].Length][];

            var index = 0;

            while (index < matrix[0].Length)
            {
                result[index] = new int[matrix.Length];
                index++;
            }

            index = 0;

            while (index < matrix.Length)
            {
                var row = matrix[index];
                var indexj = 0;

                while (indexj < row.Length)
                {
                    result[indexj][index] = row[indexj];
                    indexj++;
                }

                index++;
            }


            return result;
        }
    }
}
