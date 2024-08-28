using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Subtree
    {
       

        public bool IsSubtreeAux(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null)
            {
                return true;
            }

            if (root != null & subRoot == null || root == null && subRoot != null)
            {
                return false;
            }

            return root.val == subRoot.val && IsSubtreeAux(root.left, subRoot.left) && IsSubtreeAux(root.right, subRoot.right);
        }


 

        public  bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null)
            {
                return true;
            }

            if (root != null & subRoot == null || root == null && subRoot != null)
            {
                return false;
            }

            if (root.val == subRoot.val && IsSubtreeAux(root, subRoot))
            {
                return true;
            }

            var leftInternal = IsSubtree(root.left, subRoot);
            var rightInternal = IsSubtree(root.right, subRoot);

            return leftInternal | rightInternal;
        }
    }
}
