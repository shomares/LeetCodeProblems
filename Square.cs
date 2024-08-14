using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Square
    {
        public static bool IsPerfectSquare(int num)
        {
            if(num == 1 || num == 0)
            {
                return true;
            }
            var top = num;
            var bottom = 1;
            ulong toEvaluate = 0;

            while (top >= bottom)
            {
                var middle = bottom + (top - bottom) / 2;
                 toEvaluate =  (ulong)middle * (ulong)middle;

                if (toEvaluate == (ulong)num)
                {
                    return true;
                }

                if (toEvaluate > (ulong)num)
                {
                    top = middle - 1;
                }
                else
                {
                    bottom = middle + 1;
                }
            }



            return false;
        }
    }
}
