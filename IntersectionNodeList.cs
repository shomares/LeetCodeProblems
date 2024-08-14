using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IntersectionNodeList
    {
        public static ListNode GetIntersectionNodeAdvanced(ListNode headA, ListNode headB)
        {
            ListNode tail = headA;

            while (tail.next != null)
            {
                tail = tail.next;
            }

            tail.next = headB;

            var current = headA;
            var nextNext = current.next.next;

            while (current!= null && nextNext != null && nextNext.next !=null)
            {
                if (current == nextNext)
                {
                    tail.next = null;

                    return current;
                }

                nextNext.next = nextNext.next.next;
                current = current.next;
            }

            tail.next = null;
            return null;


        }
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var currentHeadA = headA;
            var currentHeadB = headB;

            var stackA = new List<ListNode>();
            var stackB = new List<ListNode>();

            while (currentHeadA != null && currentHeadB != null)
            {

                if (currentHeadA == currentHeadB)
                {
                    return currentHeadA;
                }

                stackA.Add(currentHeadA);
                stackB.Add(currentHeadB);

                foreach (var item in stackA)
                {
                    if (item == currentHeadB)
                    {
                        return item;
                    }
                }


                foreach (var item in stackB)
                {
                    if (item == currentHeadA)
                    {
                        return item;
                    }
                }

                currentHeadA = currentHeadA.next;
                currentHeadB = currentHeadB.next;
            }

            return null;

        }
    }
}
