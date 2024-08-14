using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Range
    {
        public static IList<string> SummaryRanges(int[] nums)
        {
            var result = new List<string>();

            if (nums == null || nums.Length == 0)
            {
                return result;
            }

            int index = 0;
            int current;
            int sizeOfRange = 0;

            Array.Sort(nums);

            int indexMustbe = nums[0];

            do
            {
                current = nums[index];

                if (current != indexMustbe)
                {
                    var left = nums[index - sizeOfRange];
                    var right = nums[index - 1];
                    indexMustbe = current;

                    if (left != right)
                    {
                        result.Add($"{left}->{right}");
                    }
                    else
                    {
                        result.Add($"{left}");
                    }

                    index--;
                    indexMustbe--;
                    sizeOfRange = 0;
                }
                else
                {
                 
                    if (index == nums.Length - 1)
                    {
                        var left = nums[index - sizeOfRange];
                        if (left != current)
                        {
                            result.Add($"{left}->{current}");
                        }
                        else
                        {
                            result.Add($"{current}");
                        }
                    }
                    else
                    {
                        sizeOfRange++;
                    }
                   
                }

                index++;
                indexMustbe++;
            } while (index < nums.Length);


            return result;
        }
    }
}
