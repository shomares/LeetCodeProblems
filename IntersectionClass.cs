using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IntersectionClass
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 || nums2.Length == 0)
            {
                return [];
            }

            var toFind = nums2;
            var source = nums1;

            Array.Sort(toFind);
            Array.Sort(source);

            var result = new List<int>();
            var indexi = 0;
            var indexj = 0;

            while (indexi < toFind.Length && indexj < source.Length)
            {
                var valueFind = toFind[indexi];
                var value = source[indexj];

                if (value == 80)
                {
                    Console.WriteLine("awe");
                }

                if (value == valueFind)
                {
                    result.Add(value);
                    indexi++;
                    indexj++;
                }
                else
                {
                    //If not is the next value
                    var position = ExistsElementBinarySearch(valueFind, source, indexj, source.Length - 1);
          
                    if (position > -1)
                    {
                        result.Add(valueFind);
                        indexj = position + 1;
                        indexi++;
                    }
                    else
                    {
                        indexi++;
                    }
                }

            }



            return [..result];

        }

        private static int ExistsElementBinarySearch(int target, int[] source, int low, int high)
        {
            int mid = -1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (source[mid] == target)
                {
                    while (source[mid] == target && mid >= low)
                    {
                        mid--;
                    }

                    return mid + 1;
                }
             
                if (source[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return mid == 0 ? -1 : -mid;

        }
    }
}
