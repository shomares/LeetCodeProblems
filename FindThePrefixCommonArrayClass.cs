using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindThePrefixCommonArrayClass
    {
        //A = [1,3,2,4], B = [3,1,2,4]
        //[0,2,3,4]
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            var cache = new HashSet<int>();
            var result = new int[A.Length];

            var index = 0;
            var times = 0;

            while (index < A.Length)
            {
                var a = A[index];
                var b = B[index];

                if (!cache.Add(a))
                {
                    times++;
                }

                if (!cache.Add(b))
                {
                    times++;
                }

                result[index] = times;

                index++;
            }

            return result;
        }
    }
}
