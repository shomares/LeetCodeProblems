using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TreeSum
    {

        public static int SumOfLeftLeavesInternal(TreeNode root, char origin)
        {
            if (root == null) return 0;

            if (root.left == null && root.right == null && origin == 'l')
            {
                return root.val;
            }

            return SumOfLeftLeavesInternal(root.left, 'l') + SumOfLeftLeavesInternal(root.right, 'r');

        }
        public static int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null || root.left == null && root.right == null)
            {
                return 0;
            }

            return SumOfLeftLeavesInternal(root.left, 'l') + SumOfLeftLeavesInternal(root.right, 'r');
        }
    }
}
