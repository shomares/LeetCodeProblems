using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountOddsClass
    {
        public int CountOdds(int low, int high)
        {
            if (low % 2 == 0 && high % 2 == 0)
            {
                return (high - low) / 2;
            }
            else if (low % 2 != 0 && high % 2 != 0)
            {
                if (low == high)
                {
                    return 1;
                }
                return (high - low - 1) / 2 + 2;
            }
            else
            {
                return (high - low - 1) / 2 + 1;
            }


        }
    }
}
