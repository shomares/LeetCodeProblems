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

                while (indexj < matrix[index].Length)
                {
                    var value = matrix[index][indexj];

                    if (value == 0)
                    {
                        matrix[index][0] = 0;
                        matrix[0][indexj] = 0;

                        if (index != 0 & indexj != 0)
                        {
                            matrix[index][indexj] = int.MinValue;
                        }
                    }

                    indexj++;
                }


                index++;
            }

            index = 0;
            while (index < matrix.Length)
            {
                if (matrix[index][0] == 0)
                {
                    FillZeroes(0, index, matrix, false);
                    FillZeroes(index, 0, matrix, true);
                }

                index++;
            }

       

        }

        private void FillZeroes(int index, int indexj, int[][] matrix, bool columns)
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

    }
}
