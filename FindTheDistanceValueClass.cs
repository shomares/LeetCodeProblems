using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindTheDistanceValueClass
    {
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            Array.Sort(arr2);
            var index = 0;
            int diff;

            var result = 0;

            while (index < arr1.Length)
            {
                var value = arr1[index];
                var nearValue = FindIndexNearValue(value, arr2);

                //Calculate borders
                diff = Math.Abs(value - arr2[0]);

                if (diff <= d)
                {
                    index++;
                    continue;
                }

                diff = Math.Abs(value - arr2[^1]);

                if (diff <= d)
                {
                    index++;
                    continue;
                }

                diff = Math.Abs(value - arr2[nearValue]);
                if (diff <= d)
                {
                    index++;
                    continue;
                }

                //Calculate Left value
                if (nearValue - 1 >= 0)
                {
                    diff = Math.Abs(value - arr2[nearValue - 1]);

                    if (diff <= d)
                    {
                        index++;
                        continue;
                    }
                }


                //Calculate Right value
                if (nearValue + 1 < arr2.Length)
                {
                    diff = Math.Abs(value - arr2[nearValue + 1]);
                    if (diff <= d)
                    {
                        index++;
                        continue;
                    }
                }


                result++;
                index++;
            }

            return result;
        }

        private int FindIndexNearValue(int toFind, int[] arr2)
        {
            var left = 0;
            var right = arr2.Length - 1;

            while (left < right)
            {
                var middle = left + (right - left) / 2;
                var toCompare = arr2[middle];

                if (toCompare == toFind)
                {
                    return middle;
                }

                if (toCompare < toFind)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            if (toFind > arr2[left] && left + 1 < arr2.Length)
            {

                return left + 1;
            }

            return left;
        }
    }
}
