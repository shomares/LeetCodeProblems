using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ToeplitzClass
    {

        public static bool IsToeplitzMatrix(int[][] matrix)
        {

            if (matrix.Length == 0) return false;

            var index = 0;
            var indexY = 0;

            while (indexY < matrix.Length)
            {
                index = 0;
                var matrizX = matrix[indexY];
                while (index < matrizX.Length - 1)
                {

                    var validateRow = ValidateToepRow(index, indexY, matrix);

                    if (validateRow == false)
                    {
                        return false;
                    }

                    index++;
                }

                indexY++;
            }


            return true;
        }

        private static bool ValidateToepRow(int index, int indexY, int[][] matrix)
        {
            var valueToComparer = matrix[indexY][index];

            var indexX = index + 1;
            indexY++;

            while (indexY < matrix.Length && indexX < matrix[indexY].Length)
            {

                var value = matrix[indexY][indexX];

                if (value != valueToComparer)
                {
                    return false;
                }

                indexX++;
                indexY++;
            }


            return true;
        }
    }
}
