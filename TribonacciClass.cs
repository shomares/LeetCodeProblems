using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TribonacciClass
    {


        public int Tribonacci(int n)
        {
            Dictionary<int, int> memo = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 1 },
                { 2, 1 }
            };


            for (var i = 3; i <= n; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2] + memo[i - 3];
            }

            return memo[n];
        }
    }
}
