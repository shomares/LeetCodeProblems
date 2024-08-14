using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class SingleNumberXOR
    {

        static int Xor(int a, int b)
        {
            if (a == b)
            {
                return 0;
            }

            if (a == 0)
                return b;

            if (b == 0)
                return a;

            return b;
        }

        public static int SingleNumber(int[] nums)
        {
            int result = 0;

            for (var i = 0; i < nums.Length; i++)
            {

                result = result ^ nums[i];
            }

            return result;
        }
    }
}
