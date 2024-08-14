using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseLinkList
    {
        private static ListNode newHead;

        public static ListNode ReverseRecursiveList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            //Its the last one
            if (head.next == null)
            {
                newHead = head;
                return head;
            }

            var nextItem = ReverseRecursiveList(head.next);
            nextItem.next = head;
            head.next = null;
            return head;
        }
        public static ListNode ReverseListCall(ListNode head)
        {
            newHead = null;
            if (head == null)
            {
                return null;
            }

            ReverseRecursiveList(head);
            return newHead;
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var stack = new Stack<ListNode>();
            var current = head;
            ListNode newHead;

            while (current != null)
            {
                stack.Push(current);
                current = current.next;
            }

            newHead = stack.Pop();
            var currentNew = newHead;


            while (stack.Count > 0)
            {
                currentNew.next = stack.Pop();
                currentNew = currentNew.next;
            }

            currentNew.next = null;

            return newHead;
        }

    }
}
