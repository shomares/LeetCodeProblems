using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Flowers
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var numPlaced = 0;
            for (var items = 0; items < n; items++)
            {
                var indexJ = 0;
                var isPlaced = false;

                while (indexJ < flowerbed.Length && !isPlaced)
                {
                    if (
                        (indexJ == 0 || flowerbed[indexJ - 1] == 0)
                        && flowerbed[indexJ] == 0
                        && ( indexJ + 1 == flowerbed.Length || flowerbed[indexJ + 1] == 0)
                        )
                    {
                        isPlaced = true;
                        numPlaced++;
                        flowerbed[indexJ] = 1;
                    }

                    indexJ++;
                }
            }

            return numPlaced == n;
        }
    }
}
