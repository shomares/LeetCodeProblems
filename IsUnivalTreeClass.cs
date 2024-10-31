using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IsUnivalTreeClass
    {
        private int? value = null;

        public bool IsUnivalTree(TreeNode root)
        {
            value = root.val;

            return IsUnivalTreeInternal(root.left) && IsUnivalTreeInternal(root.right);

        }

        private bool IsUnivalTreeInternal(TreeNode? node)
        {
            if (node == null)
            {
                return true;
            }

            return node.val == value && IsUnivalTreeInternal(node.left) && IsUnivalTreeInternal(node.right);
        }
    }
}
