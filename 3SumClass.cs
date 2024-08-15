using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _3SumClass
    {

        public static int BinarySearch(int min, int max, int key, int[] inputArray)
        {

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return -1;
        }


        public static IList<IList<int>> ThreeSumAvanced(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            if (nums.Length < 3)
            {
                return result;
            }
            var index = 0;

            while (index < nums.Length)
            {
                var a = -nums[index];
                var right = nums.Length - 1;
                var left = index + 1;

                while (left < right)
                {
                    var b = nums[left];
                    var c = nums[right];
                    var sum = b + c;

                    if (sum == a)
                    {
                        result.Add(new List<int>() { -a, b, c });

                        while (right < nums.Length - 1 && nums[right + 1] == nums[right])
                        {
                            right--;
                        }

                        while (left < nums.Length - 1 && nums[left - 1] == nums[left])
                        {
                            left++;
                        }

                    }
                    else if (sum < a)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }


                }



                index++;

            }


            return result;

        }



        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return new List<IList<int>>();
            }

            var result = new List<IList<int>>();
            Array.Sort(nums);
            var indexj = nums.Length - 1;
            var map = new HashSet<string>();

            while (indexj >= 0)
            {
                var x = nums[indexj];
                var index = 0;
                while (index < indexj)
                {
                    var y = nums[index];
                    var z = -(x + y);
                    var toFind = BinarySearch(index + 1, indexj - 1, z, nums);
                    if (toFind != -1)
                    {
                        var key = $"{(x > y ? x : y)}{z}";
                        if (map.Add(key))
                        {
                            result.Add(new List<int>() { x, y, z });
                        }

                    }

                    index++;
                }

                indexj--;
            }

            return result;
        }
    }
}
