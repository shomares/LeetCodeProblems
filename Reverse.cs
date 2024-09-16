using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Reverse
    {
        public static void Rotate(int[][] matrix)
        {
            var index = 0;
            int indexj;

            while (index < matrix.Length)
            {
                indexj = index;
                while (indexj < matrix[index].Length)
                {
                    var auxX = matrix[index][indexj];
                    var auxY = matrix[indexj][index];

                    matrix[indexj][index] = auxX;
                    matrix[index][indexj] = auxY;
                    indexj++;
                }

                index++;
            }

            index = 0;

            while (index < matrix.Length)
            {
                var indexL = 0;
                var indexR = matrix[index].Length - 1;

                while (indexL <= indexR)
                {
                    (matrix[index][indexL], matrix[index][indexR]) = (matrix[index][indexR], matrix[index][indexL]);
                    indexL++;
                    indexR--;
                }

                index++;
            }
        }
    }
}
