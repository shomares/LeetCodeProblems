using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CanBeEqualClass
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            var cache = new HashSet<int>(target);

            foreach (var item in arr)
            {
                if (!cache.Contains(item))
                {
                    return false;
                }
            }

            Array.Sort(target);
            Array.Sort(arr);

            var index = 0;

            while (index < target.Length)
            {
                if (target[index] != arr[index])
                {
                    return false;
                }

                index++;
            }

            return true;
        }
    }
}
