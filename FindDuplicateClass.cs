﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindDuplicateClass
    {
        public int FindDuplicate(int[] nums)
        {
            var slow = 0;
            var fast = 0;

            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];

            } while (slow != fast);


            slow = 0;

            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return slow;

        }
    }
}
