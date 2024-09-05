using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RobotCircleSim
    {
        public static bool JudgeCircle(string moves)
        {
            int x = 0,  y = 0;

            foreach (var move in moves)
            {
                if(move == 'R')
                {
                    x++;
                }

                if(move == 'L')
                {
                    x--;
                }

                if(move == 'U')
                {
                    y++;
                }

                if(move == 'D')
                {
                    y--;
                }

            }

            return x == 0 && y == 0;
        }

    }
}
