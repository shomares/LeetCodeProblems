using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }


        public static ListNode ConvertToList(params int[] param)
        {
            ListNode root = new ListNode();
            var result = root;
            foreach (var item in param)
            {
                var itemNode = new ListNode(item);
                root.next = itemNode;
                root = root.next;
            }

            return result.next;
        }

        public static IEnumerable<int> ConvertToArray(ListNode root)
        {
            var array = new List<int>();
            var head = root;

            while (head != null)
            {
                array.Add(head.val);
                head = head.next;
            }

            return array.ToArray();
        }
    }


    internal class MergedList
    {

        public static ListNode MergeTwoListsRecursive(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            if(list1.val < list2.val)
            {
                list1.next = MergeTwoListsRecursive(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoListsRecursive(list1, list2.next);
                return list2;
            }
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var toc = list1;
            var toCompare = list2;
            var head = list1;

            if (list1 == null && list2 == null)
            {
                return null;
            }

            if (list1 == null || list1.val == null)
            {
                return new ListNode(list2.val, list2.next);
            }

            while (toCompare != null)
            {
                var antToc = toc;
                while (toc != null && toc.val < toCompare.val)
                {
                    antToc = toc;
                    toc = toc.next;
                }

                if (toc != null)
                {
                    var orginal = toc.val;
                    toc.val = toCompare.val;
                    toc.next = new ListNode(orginal, toc.next);
                }
                else if (antToc != null)
                {
                    antToc.next = toCompare;
                }

                toCompare = toCompare.next;
            }

            return head;
        }

        private static ListNode CreateFromArrayRecursive(int index, params int[] array)
        {
            if (index >= array.Length)
            {
                return null;
            }

            ListNode node = new();

            if (index < array.Length)
            {
                node.val = array[index];
                node.next = CreateFromArrayRecursive(index + 1, array);
            }

            return node;
        }

        public static ListNode CreateFromArray(params int[] array) => CreateFromArrayRecursive(0, array);

    }
}
