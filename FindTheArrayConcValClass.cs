using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindTheArrayConcValClass
    {
        public long FindTheArrayConcVal(int[] nums)
        {
            var index = 0;
            var indexj = nums.Length - 1;
            long result = 0L;

            while (index <= indexj)
            {
                var auxL = nums[index];
                var auxR = index == indexj ? 0 : nums[indexj];

                var concatenate = $"{auxL}{(index == indexj ? string.Empty : auxR)}";
                result += long.Parse(concatenate);


                index++;
                indexj--;
            }

            return result;
        }
    }
}
