using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class StableMountainsClass
    {
        public IList<int> StableMountains(int[] height, int threshold)
        {
            var result = new List<int>();

            for(int i = 1; i < height.Length; i++)
            {
                if (height[i -1] > threshold)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
