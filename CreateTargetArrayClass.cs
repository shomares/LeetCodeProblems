using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CreateTargetArrayClass
    {

        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            var root = new ListNode
            {
                val = -1
            };

            var result = new int[nums.Length];

            ListNode current = root;

            var indexI = 0;
            var sizeOfListNode = 0;

            while (indexI < nums.Length)
            {
                var num = nums[indexI];
                var i = index[indexI];

                if (indexI == 0 || sizeOfListNode <= i)
                {
                    current.next = new ListNode { val = num };
                    current = current.next;
                }
                else
                {
                    var toFind = root;
                    ListNode? antToFind = root;
                    var j = 0;

                    while (j <= i)
                    {
                        antToFind = toFind;
                        toFind = toFind.next;
                        j++;
                    }

                    if (antToFind != null)
                    {
                        antToFind.next = new ListNode
                        {
                            val = num,
                            next = toFind
                        };
                    }

                }

                sizeOfListNode++;
                indexI++;
            }

            indexI = 0;

            current = root;

            while (current != null)
            {
                if (indexI > 0)
                {
                    result[indexI - 1] = current.val;
                }

                current = current.next;
                indexI++;
            }

            return result;
        }
    }
}
