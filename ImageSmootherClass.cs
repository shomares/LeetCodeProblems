using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ImageSmootherClass
    {
        public static int[][] ImageSmoother(int[][] img)
        {
            var calculated = new int[img.Length][];

            for (var index = 0; index < img.Length; index++)
            {
                calculated[index] = new int[img[index].Length];

                for (var indexj = 0; indexj < img[index].Length; indexj++)
                {
                    var sum = img[index][indexj];
                    var numbers = 1;
                    //leftValue 
                    if (indexj - 1 >= 0)
                    {
                        sum += img[index][indexj - 1];
                        numbers++;
                    }

                    //rightValue
                    if (indexj + 1 < img[index].Length)
                    {
                        sum += img[index][indexj + 1];
                        numbers++;
                    }

                    //topValue
                    if (index - 1 >= 0)
                    {
                        sum += img[index - 1][indexj];
                        numbers++;
                    }

                    //bottomValue
                    if (index + 1 < img.Length)
                    {
                        sum += img[index + 1][indexj];
                        numbers++;
                    }

                    //Diagonal 
                    if (indexj + 1 < img[index].Length && index + 1 < img.Length)
                    {
                        sum += img[index + 1][indexj + 1];
                        numbers++;
                    }

                    if (indexj - 1 >= 0 && index + 1 < img.Length)
                    {
                        sum += img[index + 1][indexj - 1];
                        numbers++;
                    }

                    if (indexj - 1 >= 0 && index - 1 >= 0)
                    {
                        sum += img[index - 1][indexj - 1];
                        numbers++;
                    }

                    if (indexj + 1 < img[index].Length && index - 1 >= 0)
                    {
                        sum += img[index - 1][indexj + 1];
                        numbers++;
                    }

                    calculated[index][indexj] = sum / numbers;
                }
            }

            return calculated;

        }

    }
}
