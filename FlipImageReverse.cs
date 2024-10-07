using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FlipImageReverse
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {
            var result = new int[image.Length][];

            var index = 0;

            while (index < image.Length)
            {
                var row = image[index];
                var indexjL = 0;
                var indexjR = row.Length - 1;

                result[index] = new int[row.Length];
                while (indexjL <= indexjR)
                {
                    result[index][indexjL] = row[indexjR] == 1 ? 0 : 1;
                    result[index][indexjR] = row[indexjL] == 1 ? 0 : 1;
                    indexjL++;
                    indexjR--;
                }


                index++;
            }


            return result;
        }
    }
}
