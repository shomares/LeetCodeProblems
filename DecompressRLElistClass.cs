using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DecompressRLElistClass
    {
        public int[] DecompressRLElist(int[] nums)
        {
            var size = 0;
            var index = 0;

            while (index < nums.Length)
            {
                size += nums[index];
                index += 2;
            }

            var result = new int[size];


            index = 0;
            var indexj = 0;

            while (indexj < nums.Length - 1)
            {
                var frequency = nums[indexj];
                var value = nums[indexj + 1];

                for (var i = 0; i < frequency; i++)
                {
                    result[index] = value;
                    index++;
                }

                indexj += 2;
            }


            return result;
        }
    }
}
