using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NNodes
    {

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int count = 0;
            var next = head;

            while (next != null)
            {
                count++;
                next = next.next;
            }

            var previous = head;
            var realIndex = count - n;
            var indexJ = 0;
            var slow = head;

            if(realIndex == 0)
            {
                head = head.next;
                return head;
            }

            while (previous != null && indexJ < realIndex)
            {
                previous = slow;
                slow = slow.next;
                indexJ++;
            }


            previous.next = slow.next;
            return head;
        }
    }
}
