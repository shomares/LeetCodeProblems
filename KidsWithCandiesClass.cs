using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class KidsWithCandiesClass
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new List<bool>();

            var maxValue = int.MinValue;

            foreach (var cand in candies)
            {
                if (cand > maxValue)
                {
                    maxValue = cand;
                }
            }


            foreach (var cand in candies)
            {
                result.Add((cand + extraCandies) > maxValue);
            }

            return result;
        }
    }
}
