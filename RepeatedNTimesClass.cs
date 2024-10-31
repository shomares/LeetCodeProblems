using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RepeatedNTimesClass
    {
        public int RepeatedNTimes(int[] nums)
        {
            var hashset = new HashSet<int>();

            foreach(var n in nums)
            {
                if (!hashset.Add(n))
                {
                    return n;
                }
            }

            return 0;
        }
    }
}
