using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ClimbStairsClass
    {
        /// <summary>
        /// Fibonnaci resolves
        /// </summary>
        /// <param name="n">Number of items</param>
        /// <returns></returns>
        public static int ClimbStairs(int n)
        {
            int prev = 1;
            int prev2 = 1;
            // Running for loop to count all possible ways
            for (int i = 2; i <= n; i++)
            {
                int curr = prev + prev2;
                prev2 = prev;
                prev = curr;
            }

            return prev;
      
        }
    }
}
