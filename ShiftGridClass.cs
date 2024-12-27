using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ShiftGridClass
    {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            var gridSize = grid.Length * grid[0].Length;
            var indexFlat = 0;
            var flatlist = new int[gridSize];


            for (var index = 0; index < grid.Length; index++)
            {
                for (var indexj = 0; indexj < grid[0].Length; indexj++)
                {
                    flatlist[(indexFlat + k) % gridSize] = grid[index][indexj];
                    indexFlat++;
                }
            }

            indexFlat = 0;

            for (var index = 0; index < grid.Length; index++)
            {
                for (var indexj = 0; indexj < grid[0].Length; indexj++)
                {
                    grid[index][indexj] = flatlist[indexFlat++];
                }
            }


            return grid;
        }
    }
}
