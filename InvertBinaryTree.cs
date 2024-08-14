using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class InvertBinaryTree
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var aux = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(aux);

            return root;
        }

    }
}
