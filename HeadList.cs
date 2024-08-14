using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class HeadList
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode? prev = null;
            var currentNode = head;

            while (currentNode != null)
            {
                if (prev != null && currentNode.val == prev.val)
                {
                    //Remove element
                    prev.next = currentNode.next;
                    currentNode = prev;
                }

                prev = currentNode;
                currentNode = currentNode.next;
            }

            return head;
        }
    }
}
