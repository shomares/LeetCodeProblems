using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SortArrayByParityClass
    {
        public int[] SortArrayByParity(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums;
            }

            var index = 0;
            var indexj = 1;

            while (index < nums.Length && indexj < nums.Length)
            {
                var value = nums[index];
                var valueRigth = nums[indexj];


                //Pair
                if (value % 2 == 0)
                {
                    index++;

                    if (valueRigth % 2 == 0)
                    {
                        indexj++;
                    }
                }
                //Odd
                else
                {
                    if (index < nums.Length - 1 && valueRigth % 2 == 0)
                    {
                        (nums[index], nums[indexj]) = (nums[indexj], nums[index]);
                        index++;
                        indexj++;
                    }
                    else
                    {
                        indexj++;
                    }
                }

            }

            return nums;
        }
    }
}
