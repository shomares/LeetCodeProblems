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
            var index = 1;

            while (index < matrix.Length)
            {
                var indexj = 1;

                while (indexj < matrix[index].Length)
                {
                    var value = matrix[index][indexj];

                    if (value == 0)
                    {
                        matrix[index][0] = 0;
                        matrix[0][indexj] = 0;
                        matrix[^1][0] = 0;
                        matrix[0][matrix[0].Length - 1] = 0;

                    }

                    indexj++;
                }


                index++;
            }

            index = 0;

            while (index < matrix.Length)
            {
                var indexj = 0;

                while (indexj < matrix[index].Length)
                {

                    if (matrix[index][indexj] == 0 && matrix[^1][indexj] == 0)
                    {
                        FillZeroesAll(index, 0, matrix, true);
                        FillZeroesAll(0, indexj, matrix, false);
                    }

                    indexj++;
                }
                index++;
            }

        }


        private void FillZeroesAll(int index, int indexj, int[][] matrix, bool columns)
        {
            //fill columns
            var indexk = 0;

            if (columns)
            {
                while (indexk < matrix[index].Length)
                {
                    matrix[index][indexk] = 0;
                    indexk++;
                }
            }
            else
            {
                while (indexk < matrix.Length)
                {
                    matrix[indexk][indexj] = 0;
                    indexk++;
                }
            }


        }

        private void FillZeroes(int index, int indexj, int[][] matrix, bool columns)
        {
            //fill columns
            var indexk = 1;

            if (columns)
            {
                while (indexk < matrix[index].Length - 1)
                {
                    matrix[index][indexk] = 0;
                    indexk++;
                }
            }
            else
            {
                while (indexk < matrix.Length - 1)
                {
                    matrix[indexk][indexj] = 0;
                    indexk++;
                }
            }


        }
    }

}