using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class KLengthApartClass
    {
        //1,0,0,0,1,0,0,1
        //2
        public bool KLengthApart(int[] nums, int k)
        {

            var index = 0;
            var currentLenght = 0;

            while (index < nums.Length)
            {
                var item = nums[index];
                if (item == 0)
                {
                    currentLenght++;
                }
                else
                {
                    if (index > 0 && currentLenght < k)
                    {
                        return false;
                    }

                    currentLenght = 0;
                }

                index++;
            }


            if (nums[^1] == 0 && currentLenght < k)
            {
                return false;
            }

            return true;
        }
    }
}
