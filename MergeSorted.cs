using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MergeSorted
    {
        //[1,2,3,0,0,0]
        //[2,5,6]
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int index = 0;
            while (index < n)
            {
                var toInsert = nums2[index];
                var size = m + index;

                if (m == 0)
                {
                    nums1[index] = toInsert;
                }
                else if (toInsert < nums1[0])
                {
                    MoveToRight(0, nums1, size);
                    nums1[0] = toInsert;
                }
                else if (toInsert > nums1[size -1])
                {
                    nums1[size] = toInsert;
                }
                else
                {
                    var indexToInsert = SearchBinarySearch(toInsert, nums1, size);
                    MoveToRight(indexToInsert, nums1, size);
                    nums1[indexToInsert] = toInsert;
                }
              
                index++;
            }

        }

        private static void MoveToRight(int indexToInsert, int[] nums1, int size)
        {
            var index = indexToInsert + 1;
            var prev = nums1[indexToInsert];
            while (index <= size && index < nums1.Length)
            {
                int ant = nums1[index];
                nums1[index] = prev;
                prev = ant;
                index++;
            }

        }

        private static int SearchBinarySearch(int toInsert, int[] nums1, int size)
        {
            int low = 0, high = size -1, mid = 0;

            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums1[mid] == toInsert)
                    return mid;

                if (nums1[mid] < toInsert)
                    low = mid + 1;
                else
                    high = mid - 1;
            }


            if (nums1[mid] > toInsert)
            {
                return mid;
            }

            if (mid + 1 >= nums1.Length)
            {
                return mid + 1;
            }

            if (nums1[mid + 1] > toInsert)
            {
                return mid + 1;
            }

            return mid;
        }
    }
}
