using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MyMaths
    {
        public static int MySqrt(int x)
        {
            if(x == 0 || x == 1)
            {
                return x;
            }

            int mid = x;
            var low = 0;
            var high = x;
            while (low <= high)
            {
                mid = low + (high - low) / 2;

                if (mid == x / mid)
                {
                    return mid;
                }

                if (mid < x / mid)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return high;
        }
    }
}
