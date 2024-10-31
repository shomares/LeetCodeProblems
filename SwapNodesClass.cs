using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SwapNodesClass
    {
        private ListNode? newHead = null;
        private int countInt = 0;

        private ListNode? GetLastKItem(ListNode? node, int k)
        {
            if (node == null)
            {
                return null;
            }

            if (node.next == null)
            {
                newHead = node;
                return node;
            }

            var nextItem = GetLastKItem(node.next, k);

            if (newHead != null && countInt != k)
            {
                countInt++;
            }

            if (countInt == k)
            {
                return nextItem;
            }

            return node;
        }

        public ListNode SwapNodes(ListNode head, int k)
        {
            var headCur = head;
            var current = head;
            var index = 0;

            while (index < k - 1 && current != null)
            {
                current = current.next;
                index++;
            }

            if (current == null)
            {
                return headCur;
            }

            newHead = null;
            countInt = 0;

            var lastItem = GetLastKItem(head, k);

            (current.val, lastItem.val) = (lastItem.val, current.val);
            return headCur;
        }
    }
}
