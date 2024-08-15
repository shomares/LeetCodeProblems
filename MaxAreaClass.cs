using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaxAreaClass
    {
        public static int MaxArea(int[] height)
        {
            var index = 0;
            var indexj = height.Length - 1;
            var max = 0;

            while (index < indexj)
            {
                var width = indexj - index;
                var heigth = Math.Min(height[index], height[indexj]);

                var area = width * heigth;

                if (area > max)
                {
                    max = area;
                }

                if (height[indexj] > height[index])
                {
                    index++;
                }
                else
                {
                    indexj--;
                }

            }

            return max;
        }
    }
}
