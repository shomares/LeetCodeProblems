using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PerimeterIsland
    {
       
        public static int FindTheRoute(int index, int indexj, int indexPrev, int indexJPrev, int[][] grid)
        {
            var result = 0;
            if (index < 0 || index == grid.Length || indexj < 0 || indexj == grid[index].Length)
            {
                return 1;
            }

            var value = grid[index][indexj];
            if (value == 0)
            {
                return 1;
            }

            if (value == -1)
            {
                return 0;
            }

            grid[index][indexj] = -1;

            //left value
            if (indexPrev != index || indexJPrev != indexj - 1)
            {
                result += FindTheRoute(index, indexj - 1, index, indexj, grid);
            }

            //right value
            if (indexPrev != index || indexJPrev != indexj + 1)
            {
                result += FindTheRoute(index, indexj + 1, index, indexj, grid);
            }


            //top value
            if (indexPrev != index - 1 || indexJPrev != indexj)
            {
                result += FindTheRoute(index - 1, indexj, index, indexj, grid);
            }

            //bottom value
            if (indexPrev != index + 1 || indexJPrev != indexj)
            {
                result += FindTheRoute(index + 1, indexj, index, indexj, grid);
            }

          

            return result;
        }

        public static int IslandPerimeter(int[][] grid)
        {
            //Get the first item with 1-------------------
            for (int index = 0; index < grid.Length; index++)
            {
                for (int indexj = 0; indexj < grid[index].Length; indexj++)
                {
                    var value = grid[index][indexj];

                    if (value == 1)
                    {
                        return FindTheRoute(index, indexj, int.MinValue, int.MinValue, grid);
                    }
                }

            }

            return 0;
        }


    }
}
