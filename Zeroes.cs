using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Zeroes
    {

        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length < 2)
            {
                return;
            }

            var index = 0;
            var jindex = 1;

            while (index < nums.Length && jindex < nums.Length)
            {
                var ivalue = nums[index];
                var jvalue = nums[jindex];

                if (ivalue == 0 && jvalue != 0)
                {
                    nums[jindex] = ivalue;
                    nums[index] = jvalue;
                    index++;
                    jindex++;
                }
                else if (ivalue != 0 && jvalue == 0)
                {
                    index = jindex;
                    jindex++;
                }
                else if (ivalue == 0 && jvalue == 0)
                {
                    jindex++;
                }
                else
                {
                    index++;
                    jindex++;
                }
            }
        }
    }
}
