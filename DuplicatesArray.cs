using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DuplicatesArray
    {

        public static int RemoveElementMajor(int[] nums, int val)
        {
            int i = 0, lenght = 0, k = 0; 
            var stack = new Stack<int>();

            while (i < nums.Length)
            {
                if (nums[i] != val)
                {
                    stack.Push(nums[i]);
                    lenght++;
                    k++;
                }

                i++;
            }

          
            while(stack.Count > 0)
            {
                var value = stack.Pop();
                nums[lenght -1] = value;
                lenght--;
            }

            return k;
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int i;
            var j = 0;
            var k = 0;

            while (j>=0 && j < nums.Length - k)
            {
                var toCompare = nums[j];

                if (toCompare == val)
                {
                    i = j + 1;
                    k++;
                    while (i < nums.Length)
                    {
                        int aux = nums[i - 1];
                        nums[i - 1] = nums[i];
                        nums[i] = aux;
                        i++;
                    }

                    if (j > 0)
                    {
                        j--;
                    }
                }
                else
                {
                    j++;
                }
            }

            return nums.Length - k;
        }


        public static int RemoveDuplicates(int[] nums)
        {

            var k = 0;
            for (int indexj = 1; indexj < nums.Length; indexj++)
            {
                if (nums[k] != nums[indexj])
                {
                    k++;
                    nums[k] = nums[indexj];
                }

            }

            return k + 1;
        }
    }
}
