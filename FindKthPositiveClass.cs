using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindKthPositiveClass
    {
        public int FindKthPositive(int[] arr, int k)
        {
            if (arr[^1] == arr.Length)
            {
                return arr[^1] + k;
            }

            var calculated = arr[^1] - 1 - (arr.Length - 1);

            if (calculated < k)
            {
                return arr[^1] + (k - calculated);
            }


            var left = 0;
            var right = arr.Length - 1;

            var result = -1;

            while (left < right)
            {
                var middle = left + (right - left) / 2;
                var find = arr[middle] - 1 - middle;
                if (find < k)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }


            result = result == -1 ? left : result;

            var calculatedFinal = arr[result] - 1 - result;

            if (calculatedFinal < k)
            {
                return (k - calculatedFinal) + arr[result];
            }

            result -= 1;

            if (result < 0)
            {
                return k;
            }

            calculatedFinal = arr[result] - 1 - result;
            return (k - calculatedFinal) + arr[result];
        }
    }
}
