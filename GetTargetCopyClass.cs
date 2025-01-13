using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class GetTargetCopyClass
    {
        private TreeNode? _founded = null;
        private bool _isEqual = true;

        private void IsEqual(TreeNode? toCompare, TreeNode? founded)
        {
            if (toCompare == null && founded == null) return;

            if (toCompare.val != founded.val)
            {
                _isEqual = false;
                return;
            }

            if ((toCompare.left == null && founded.left != null) || (toCompare.left != null && toCompare.left == null))
            {
                _isEqual = false;
                return;
            }


            if ((toCompare.right == null && founded.right != null) || (toCompare.right != null && founded.right == null))
            {
                _isEqual = false;
                return;
            }

            IsEqual(toCompare.left, founded.left);
            IsEqual(toCompare.right, founded.right);

        }

        private void Find(TreeNode? tree, TreeNode target)
        {
            if (tree == null || _founded != null)
            {
                return;
            }

            if (tree.val == target.val)
            {
                _founded = tree;
                //Compare all items ---------------------------------------------------
                IsEqual(tree, target);

                if (_isEqual)
                {
                    return;
                }
                else
                {
                    _isEqual = true;
                    _founded = null;
                }

            }
            else
            {
                if (_founded == null)
                {
                    Find(tree.left, target);
                    Find(tree.right, target);
                }

            }
        }

        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            _founded = null;
            _isEqual = true;
            Find(cloned, target);

            if (_isEqual && _founded != null)
            {
                return _founded;

            }

            return null;
        }
    }
}
