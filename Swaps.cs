using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public  class Swaps
    {
        private  bool hasReached = false;

        public  ListNode? SwapPairsinternal(ListNode parent, ListNode current, int index)
        {
            if (current == null)
            {
                hasReached = true;
                return index % 2 != 0 ? null : parent;
            }

            parent.next = SwapPairsinternal(current, current.next, index + 1);

            //is pair then swap
            if (hasReached && index % 2 == 0)
            {
                parent.next = current.next;
                current.next = parent;
                return current;
            }

            return parent;
        }


        public ListNode SwapPairs(ListNode head)
        {
            hasReached = false;
            if(head == null)
            {
                return null;
            }

            if(head.next == null)
            {
                return head;
            }

            return SwapPairsinternal(head, head.next, 0);
        }
    }
}
