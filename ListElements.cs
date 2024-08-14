using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ListElements
    {
        public static ListNode RemoveElements(ListNode head, int val)
        {
            var current = head;
            ListNode ant = new(-1, head);

            while (current != null)
            {
                if(current.val == val)
                {
                    if (ant.next == head)
                    {
                        head = current.next;
                    }

                    ant.next = current.next;
                }
                else
                {
                    ant = current;
                }

                current = current.next;

            }

            return head;
        }
    }
}
