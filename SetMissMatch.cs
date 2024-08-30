using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SetMissMatch
    {
        public static int[] FindErrorNums(int[] nums)
        {

            var set = new HashSet<int>();
            int[] res = new int[2];

            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    res[0] = num;
                }

                set.Add(num);
            }

            for (int num = 1; num <= nums.Length; num++)
            {
                if (!set.Contains(num)) res[1] = (num);
            }



            return res;
           
        }
    }
}
