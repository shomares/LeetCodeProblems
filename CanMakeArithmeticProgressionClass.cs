using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CanMakeArithmeticProgressionClass
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);

            var difference = arr[1] - arr[0];

            var index = 2;

            while (index < arr.Length)
            {
                var diff = arr[index] - arr[index - 1];

                if (difference != diff)
                {
                    return false;
                }

                index++;
            }

            return true;
        }
    }
}
