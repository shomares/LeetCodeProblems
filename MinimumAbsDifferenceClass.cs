using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MinimumAbsDifferenceClass
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            var result = new List<IList<int>>();

            Array.Sort(arr);

            var index = 1;

            var minValue = int.MaxValue;

            while (index < arr.Length)
            {
                var x = arr[index];
                var y = arr[index - 1];

                var abs = x - y;

                if (abs < minValue)
                {
                    minValue = abs;
                    result.Clear();
                    result.Add(new List<int>() { y, x });
                }else if (abs == minValue)
                {
                    result.Add(new List<int>() { y, x });
                }

                index++;
            }

            return result;
        }
    }
}
