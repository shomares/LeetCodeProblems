using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LinkedPalindrome
    {
        private ListNode? head;
        private bool startToCompare = false;


        private ListNode ReverseAndCompareRecursive(ListNode root)
        {
            if (root.next == null)
            {
                startToCompare = true;
                return root;
            }

            var nextValue = ReverseAndCompareRecursive(root.next);

            if (startToCompare)
            {
                if (nextValue.val != head.val)
                {
                    throw new Exception();
                }

                head = head.next;
            }

            return root;
        }

        public bool IsPalindrome(ListNode head)
        {
            this.head = head;
            try
            {
                var lastOne = ReverseAndCompareRecursive(head);
                return lastOne.val == head.val;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }

        public bool IsPalindromeAdvanced(ListNode head)
        {
            if(head.next == null)
            {
                return false;
            }

            var slow = head;
            var fast = head.next.next;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }


            var start = slow.next;


            var reverse = Reverse(start);
            var current = head;

            while (reverse != null && current != null)
            {
                if (current.val != reverse.val)
                {
                    return false;
                }

                current = current.next;
                reverse = reverse.next;
            }


            return true;

        }
    }
}
