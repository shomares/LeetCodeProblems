using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PairSumClass
    {
        private ListNode newHead;

        public ListNode ReverseRecursiveList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            //Last one list node
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

        public int PairSum(ListNode head)
        {


            var slow = head;
            var fast = head.next;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            newHead = null;
            ReverseRecursiveList(slow.next);

            var currentFirst = head;
            var currentSecond = newHead;
            var result = int.MinValue;

            while (currentSecond != null)
            {
                var sum = currentFirst.val + currentSecond.val;
                result = Math.Max(result, sum);

                currentFirst = currentFirst.next;
                currentSecond = currentSecond.next;
            }

            return result;
        }
    }
}
