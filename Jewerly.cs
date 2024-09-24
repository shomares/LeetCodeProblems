using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Jewerly
    {
        public static int NumJewelsInStones(string jewels, string stones)
        {
            var hashMap = new HashSet<char>(jewels);

            var index = 0;
            var counted = 0;

            while (index < stones.Length)
            {
                var c = stones[index];

                if (hashMap.Contains(c))
                {
                    counted++;
                }

                index++;
            }

            return counted;
        }
    }
}
