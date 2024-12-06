using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ThreeConsecutiveOddsClass
    {

        public bool ThreeConsecutiveOdds(int[] arr)
        {
            var index = 0;
            var oods = 0;

            while (index < arr.Length)
            {
                int number;
                do
                {
                    number = arr[index++];

                    if(number % 2 != 0)
                    {
                        oods++;
                    }

                } while (number % 2 != 0 && index < arr.Length);


                if (oods >= 3)
                {
                    return true;
                }
                else
                {
                    oods = 0;
                }

            }

            return false;
        }
    }
}
