using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CheckIfExistClass
    {

        public bool CheckIfExist(int[] arr)
        {
            var index = 0;
            var copyN2 = new Dictionary<int, HashSet<int>>();

            while (index < arr.Length)
            {
                var key = arr[index] * 2;

                if (copyN2.TryGetValue(key, out var value))
                {
                    value.Add(index);
                }
                else
                {
                    copyN2[key] = [index];
                }

                index++;
            }

            index = 0;

            while (index < arr.Length)
            {
                var item = arr[index];

                if (item % 2 != 0)
                {
                    index++;
                    continue;
                }

                if (copyN2.TryGetValue(item, out var value) && ((item == 0 && value.Count > 1) || !value.Contains(index)))
                {
                    return true;
                }

                index++;
            }

            return false;
        }
    }
}
