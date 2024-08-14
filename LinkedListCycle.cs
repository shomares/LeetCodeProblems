using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LinkedListCycle
    {
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }

            var headCurrent = head;
            var next = head.next.next;

            while (headCurrent != null && next != null && next.next != null)
            {
                if (headCurrent == next)
                {
                    return true;
                }

                headCurrent = headCurrent.next;
                next = next.next.next;
            }

            return false;
        }
    }
}
