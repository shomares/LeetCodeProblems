using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FibClass
    {
        public int Fib(int n)
        { 
            if(n == 1)
            {
                return 1;
            }

            if( n == 0)
            {
                return 0;
            }

            var r0 = 0;
            var r1 = 1;
            var result = 0;

            for (var index = 2; index <= n; index++)
            {
                result = r0 + r1;
                r0 = r1;
                r1 = result;
            }


            return result;
        }
    }
}
