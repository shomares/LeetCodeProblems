using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IsPathCrossingClass
    {
        public bool IsPathCrossing(string path)
        {
            var cache = new HashSet<string>() { 
                "0,0"
            };
            var x = 0;
            var y = 0;

            foreach (var c in path)
            {
                if (c == 'N')
                {
                    x--;
                }
                else if (c == 'S')
                {
                    x++;
                }
                else if (c == 'E')
                {
                    y--;
                }
                else
                {
                    y++;
                }

                if (!cache.Add($"{x},{y}"))
                {
                    return true;
                }
            }


            return false;
        }
    }
}
