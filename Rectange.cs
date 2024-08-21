using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Rectange
    {
        public static int[] ConstructRectangle(int area)
        {
            var root = Math.Sqrt(area);

            if (root % 1 == 0)
            {
                return [(int)root, (int)root];
            }

            var top = (int)root;

            while (top > 0)
            {
                var calc = (double)area / top;

                if(calc % 1 == 0)
                {
                    return [(int)calc, top];
                }

                top--;
            }

            return [];
        }
    }
}
