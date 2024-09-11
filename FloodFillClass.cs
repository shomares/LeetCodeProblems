using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FloodFillClass
    {
        private readonly HashSet<string> cache = [];

        public  void FloodFillRecursive(int[][] image, int sr, int sc, int color, int firstColor)
        {
            var sizeOfColumn = image[0].Length;
            if (sr == -1 || sc == -1 || sr >= image.Length || sc >= sizeOfColumn)
            {
                return;
            }

            var value = image[sr][sc];

            if (value != firstColor)
            {
                return;
            }

            image[sr][sc] = color;

            if (!cache.Add($"{sr},{sc}"))
            {
                return;
            }

            FloodFillRecursive(image, sr + 1, sc, color, firstColor);
            FloodFillRecursive(image, sr, sc + 1, color, firstColor);
            FloodFillRecursive(image, sr - 1, sc, color, firstColor);
            FloodFillRecursive(image, sr, sc - 1, color, firstColor);
        }
        public  int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if(image.Length == 0 || image[0].Length == 0)
            {
                return image;
            }

            cache.Clear();
            FloodFillRecursive(image, sr, sc, color, image[sr][sc]);
            return image;
        }
    }
}
