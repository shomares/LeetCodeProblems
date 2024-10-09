using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MonotonicClass
    {
        public bool IsMonotonic(int[] nums)
        {
            if (nums.Length <= 2)
            {
                return true;
            }

            bool? isIncreasing = null;
            var index = 1;

            while (index < nums.Length)
            {
                var ant = nums[index - 1];
                var aux = nums[index];

                if (isIncreasing == null)
                {
                    if (ant == aux)
                    {
                        index++;
                        continue;
                    }
                    else if (ant < aux)
                    {
                        isIncreasing = true;
                    }
                    else if (ant > aux)
                    {
                        isIncreasing = false;
                    }
                }
                else
                {
                    if (isIncreasing.Value && ant > aux)
                    {
                        return false;
                    }
                    else if(!isIncreasing.Value && ant < aux)
                    {
                        return false;
                    }
                }

                index++;
            }


           

            return true;
        }
    }
}
