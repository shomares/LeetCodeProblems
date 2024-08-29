using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MergeBinaryTree
    {
        private static TreeNode? MergeTreesInternal(TreeNode? root1, TreeNode? root2)
        {
            if (root1 == null && root1 == root2)
            {
                return null;
            }

            int value;
            var newNode = new TreeNode();

            if (root1 != null && root2 != null)
            {
                value = root1.val + root2.val;
            }
            else if (root1 != null && root2 == null)
            {
                value = root1.val;
            }
            else
            {
                value = root2.val;
            }

            newNode.val = value;

            newNode.left = MergeTreesInternal(root1?.left, root2?.left);
            newNode.right = MergeTreesInternal(root2?.right, root1?.right);
            return newNode;
        }

        public static TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            return MergeTreesInternal(root1, root2);
        }
    }
}
