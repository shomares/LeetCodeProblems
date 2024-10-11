using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IncreasingBSTClass
    {
       
        TreeNode? internalNode;
        TreeNode? internalRootNode;

        public void InOrder(TreeNode root)
        {
            if(root == null) return;

            InOrder(root.left);

            if(internalRootNode == null)
            {
                internalNode = new TreeNode(root.val);
                internalRootNode = internalNode;
            }
            else
            {
                internalNode.right = new TreeNode(root.val);
                internalNode = internalNode.right;
            }

         
            InOrder(root.right);
        }

        public TreeNode IncreasingBST(TreeNode root)
        {
            internalRootNode = null;
            internalNode = null;
            InOrder(root);
            return internalRootNode;
        }
    }
}
