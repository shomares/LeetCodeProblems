using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ZeroesClass
    {
        public void SetZeroes(int[][] matrix)
        {
            var index = 0;

            while (index < matrix.Length)
            {
                var indexj = 0;
                var row = matrix[index];

                while (indexj < row.Length)
                {
                    var value = row[indexj];

                    if (value == 0 && !ValidateIfPassed(index, indexj, matrix))
                    {
                        FillZeroes(index, indexj, matrix);
                    }

                    indexj++;
                }


                index++;
            }

        }

        private void FillZeroes(int index, int indexj, int[][] matrix)
        {
            //fill columns
            var indexk = 0;
            while (indexk < matrix[index].Length)
            {
                matrix[index][indexk] = 0;
                indexk++;
            }

            //fill rows
            indexk = 0;
            while (indexk < matrix.Length)
            {
                matrix[indexk][indexj] = 0;
                indexk++;
            }
        }

        private static bool ValidateIfPassed(int index, int indexj, int[][] matrix)
        {
            if (index == 0 && indexj == 0)
            {
                return false;
            }

            var row = matrix[index];
            var column = matrix[indexj];

            if (
                  matrix[index][0] == 0 &&
                  matrix[index][row.Length -1] == 0 
                )
            {



                return true;
            }

            return false;
        }
    }
}
