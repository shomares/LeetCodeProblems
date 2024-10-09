using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MiddleNodeClass
    {
        public ListNode MiddleNode(ListNode head)
        {
            if(head.next == null)
            {
                return head;
            }

            var slow = head;
            var fast = head.next.next;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow.next;

        }
    }
}
