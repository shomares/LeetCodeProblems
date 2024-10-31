using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaximumSumClass
    {
        public int MaximumSum(int[] nums)
        {
            var hashtable = new Dictionary<int, List<int>>();

            foreach (var item in nums)
            {
                int sumDigits = GetSumDigits(item);

                if (hashtable.TryGetValue(sumDigits, out var list))
                {

                    list.Add(item);
                }
                else
                {
                    hashtable.Add(sumDigits, [item]);
                }
            }


            var result = -1;
            foreach (var item in hashtable)
            {
                if (item.Value.Count > 1)
                {
                    var sortedArray = item.Value.ToArray();
                    Array.Sort(sortedArray);

                    var sum = sortedArray[^1] + sortedArray[^2];

                    if(sum > result)
                    {
                        result = sum;
                    }
                }

            }


            return result;
        }

        private int GetSumDigits(int num)
        {
            int digitSum = 0;
            while (num > 0)
            {
                digitSum += num % 10;
                num /= 10;
            }

            return digitSum;
        }
    }
}
