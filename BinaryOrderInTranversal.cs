using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class BinaryOrderInTranversal
    {

        private static void InOrder(TreeNode root, IList<int> cache)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.left, cache);
            cache.Add(root.val);
            InOrder(root.right, cache);
        }

        public static IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> cache = new List<int>();
            InOrder(root, cache);
            return cache;
        }

    }
}
