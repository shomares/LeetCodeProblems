using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    internal class GetNoZeroIntegersClass
    {
        public int[] GetNoZeroIntegers(int n)
        {
            var result = new int[2];

            var left = 1;
            var right = n - 1;

            while (left <= right)
            {
                if (ValidateNoZeros(left) && ValidateNoZeros(right))
                {
                    result[0] = left;
                    result[1] = right;
                    return result;
                }

                left++;
                right--;
            }



            return result;
        }

        private bool ValidateNoZeros(int left)
        {
            if (left < 10)
            {
                return true;
            }

            var index = 1;
            var numCopy = left;
            while (numCopy > 0)
            {
                var factor = Math.Pow(10, index);
                var toAdd = (int)(numCopy % factor);
                numCopy -= toAdd;
                var digit = (int)(toAdd / Math.Pow(10, index - 1));

                if (digit == 0)
                {
                    return false;
                }

                index++;
            }

            return true;
        }
    }
}
