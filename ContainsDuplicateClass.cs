using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ContainsDuplicateClass
    {

        public static bool ContainsNearbyDuplicateAvanced(int[] nums, int k)
        {
            var set = new HashSet<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }

                set.Add(nums[i]);
                if (set.Count > k)
                {
                    set.Remove(nums[i - k]);
                }
            }

            return false;
        }


        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums.Length < 1)
            {
                return false;
            }


            var index = 0;

            while (index < nums.Length)
            {
                var indexRigth = index + k;
                var num = nums[index];

                if (indexRigth >= nums.Length)
                {
                    indexRigth = nums.Length - 1;
                }

                if (indexRigth != index && num == nums[indexRigth])
                {
                    return true;
                }

                for (var indexj = indexRigth - 1; indexj > index; indexj--)
                {
                    if (nums[indexj] == num)
                    {
                        return true;
                    }
                }

                index++;
            }

            return false;
        }


        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length < 2)
            {
                return false;
            }

            Array.Sort(nums);
            var index = 1;
            var ant = nums[0];


            while (index < nums.Length)
            {
                var num = nums[index];

                if (ant == num)
                {
                    return true;
                }
                else
                {
                    ant = num;
                }

                index++;

            }


            return false;
        }

    }
}

