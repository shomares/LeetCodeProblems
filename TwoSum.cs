using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSumClass
    {

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for(int index = 0; index < nums.Length; index++)
            {
                int valueX = nums[index];
                for(int jindex=0; jindex<nums.Length; jindex++)
                {
                    if(jindex == index)
                    {
                        continue;
                    }

                    var valueY = nums[jindex];

                    if(valueY + valueX == target)
                    {
                        result[0] = index;
                        result[1] = jindex;
                        return result;
                    }
                }
            }

            return result;

        }
    }
}
