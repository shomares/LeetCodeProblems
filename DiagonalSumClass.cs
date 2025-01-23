using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DiagonalSumClass
    {
        public int DiagonalSum(int[][] mat)
        {
            var result = 0;
            var size = mat.Length;

            var hasCenter = size % 2 != 0;

            var index = 0;


            while (index < mat.Length)
            {
                result += mat[index][index];
                index++;
            }

            var indexj = 0;
            index = mat.Length - 1;
            while (index >= 0)
            {
                var toAdd = mat[index][indexj];

                if (hasCenter)
                {
                    if (index != indexj)
                    {
                        result += toAdd;
                    }
                }
                else
                {
                    result += toAdd;
                }

                index--;
                indexj++;
            }


            return result;
        }
    }
}
