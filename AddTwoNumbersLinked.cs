using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class AddTwoNumbersLinked
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var headL1 = l1;
            var headL2 = l2;
            var result = new ListNode();
            var headResult = result;
            var carry = 0;

            while (headL1 != null && headL2 != null)
            {
                var sum = headL1.val + headL2.val + carry;
                ListNode newNode;

                if (sum < 10)
                {
                    newNode = new ListNode(sum);
                    carry = 0;
                }
                else
                {
                    newNode = new ListNode(sum % 10);
                    carry = 1;
                }

                headL1 = headL1.next;
                headL2 = headL2.next;
                result.next = newNode;
                result = newNode;
            }

            var lastOne = headL1 ?? headL2;

            if (carry == 0 && lastOne == null)
            {
                return headResult.next;
            }

          

            if (lastOne == null)
            {
                result.next = new ListNode(carry);
                return headResult.next;
            }

            while (lastOne != null)
            {
                var sum = lastOne.val + carry;
                ListNode newNode;

                if (sum < 10)
                {
                    newNode = new ListNode(sum);
                    carry = 0;
                }
                else
                {
                    newNode = new ListNode(sum % 10);
                    carry = 1;
                }

                result.next = newNode;
                result = newNode;
                lastOne = lastOne.next;
            }

            if (carry > 0)
            {
                result.next = new ListNode(carry);
            }

            return headResult.next;
        }
    }
}
