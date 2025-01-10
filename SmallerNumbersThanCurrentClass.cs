using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SmallerNumbersThanCurrentClass
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var result = new int[nums.Length];
            var copySorted = new int[nums.Length];
            var index = 0;
            foreach (int num in nums)
            {
                copySorted[index++] = num;
            }

            Array.Sort(copySorted);

            var dictionary = new Dictionary<int, int>();

            index = 0;

            while (index < copySorted.Length)
            {
                var key = copySorted[index];
                if (!dictionary.ContainsKey(key))
                {
                    dictionary[key] = index;
                }

                index++;
            }

            index = 0;
            while (index < copySorted.Length)
            {
                var key = nums[index];
                result[index] = dictionary[key];

                index++;
            }

            return result;
        }
    }
}
