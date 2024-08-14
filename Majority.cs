using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Majority
    {

        public static int MajorityElementBoyerMaoreAlgorith(int[] nums)
        {
            if(nums.Length == 0) return 0;


            var candidate = nums[0];
            var balance = 1;
            
            for(var index=1; index<nums.Length; index++)
            {
                var i= nums[index];
                if (candidate != i)
                {
                    balance--;
                }
                else
                {
                    balance++;
                }

                if (balance <= 0)
                {
                    candidate = i;
                    balance = 1;
                }
            }

            return candidate;

        }

        public static int MajorityElementClassic(int[] nums)
        {
            var cache = new Dictionary<int, int>();
            int max = 0, maxValue = 0;

            foreach (var x in nums)
            {

                if (cache.ContainsKey(x))
                {
                    cache[x]++;
                }
                else
                {
                    cache[x] = 1;
                }

                if (max < cache[x])
                {
                    max = cache[x];
                    maxValue = x;
                }
            }

            return maxValue;

        }
    }
}
