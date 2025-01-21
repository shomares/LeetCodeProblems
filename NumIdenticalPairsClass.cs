using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NumIdenticalPairsClass
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var cache = new Dictionary<int, int>();

            var index = 0;
            var result = 0;

            while (index < nums.Length)
            {
                var item = nums[index];

                if (cache.TryGetValue(item, out var aux))
                {
                    cache[item] = ++aux;
                }
                else
                {
                    cache.Add(item, 1);
                }

                index++;
            }

            foreach (var item in cache.Values)
            {
                if (item < 2)
                {
                    continue;
                }

                result += CalcuateCombinatios(item);
            }


            return result;
        }

        //[0,3,4]
        private int CalcuateCombinatios(int item)
        {
            var result = 0;

            var index = 1;

            while (index <= item)
            {
                result += item - index;
                index++;
            }

            return result;
        }
    }
}
