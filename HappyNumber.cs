using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class HappyNumber
    {
        public static int GetValue(int n)
        {
            var sum = 0d;

            while (n > 0)
            {
                sum += Math.Pow(n % 10, 2);
                n /= 10;
            }

            return (int)sum;

        }

        public static bool IsHappy(int n)
        {
            var fast = n;
            var slow = n;

            do
            {
                slow = GetValue(slow);
                fast = GetValue(GetValue(fast));
            } while (fast != slow);


            return slow == 1;
        }
    }
}
