using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RemoveDuplicatesClass
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums.Length < 2)
            {
                return 1;
            }
            int k = 2;

            for (int i = 2; i < nums.Length; i++)
            {
                var current = nums[i];
                var toCompare = nums[k - 2];
                if (current != toCompare)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
