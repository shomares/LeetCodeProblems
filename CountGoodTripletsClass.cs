using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountGoodTripletsClass
    {

        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            var result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {

                        var diffA = Math.Abs(arr[i] - arr[j]);
                        var diffB = Math.Abs(arr[j] - arr[k]);
                        var diffC = Math.Abs(arr[i] - arr[k]);

                        if (diffA <= a && diffB <= b && diffC <= c)
                        {
                            result++;
                        }

                    }
                }
            }

            return result;
        }
    }
}
