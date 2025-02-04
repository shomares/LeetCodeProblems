using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NumSpecialClass
    {
        public int NumSpecial(int[][] mat)
        {
            var index = 0;
            var result = 0;
            var sumhorizontal = new int[mat.Length];
            var sumvertical = new int[mat[0].Length];

            while (index < mat.Length)
            {
                var indexj = 0;

                while (indexj < mat[index].Length)
                {
                    sumhorizontal[index]+= mat[index][indexj];
                    sumvertical[indexj] += mat[index][indexj];
                    indexj++;
                }
              
                index++;
            }

            index = 0;


            while (index < mat.Length)
            {
                var indexj = 0;

                while (indexj < mat[index].Length)
                {
                    var item = mat[index][indexj];

                    if (item == 1 && sumvertical[indexj] == 1 && sumhorizontal[index] == 1)
                    {
                        result++;
                    }

                    indexj++;
                }

                index++;
            }



            return result;
        }
    }
}
