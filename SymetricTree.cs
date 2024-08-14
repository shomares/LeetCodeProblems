using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SymetricTree
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p != null && q != null && p.val == q.val)
            {
                var validateLeft = IsSameTree(p.left, q.right);
                if (!validateLeft)
                {
                    return false;
                }

                var validateRight = IsSameTree(p.right, q.left);
                if (!validateRight)
                {
                    return false;
                }

                return true;
            }
            else if (p == null && q == null)
            {
                return true;
            }

            return false;
        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root.left == null && root.left == root.right)
            {
                return true;
            }

            if (root.left == null)
            {
                return false;
            }

            if (root.right == null)
            {
                return false;
            }

            return IsSameTree(root.left, root.right);

        }


        private IList<string> cache = new List<string>();

        public void BinaryTreePathsRecursive(TreeNode root, string internalCache)
        {
            //this is a leaf
            if (root.left == null && root.right == null)
            {
                var toAdd = string.IsNullOrEmpty(internalCache) ? root.val.ToString() : $"{internalCache}->{root.val}";
                cache.Add(toAdd);
                return;
            }


            internalCache += string.IsNullOrEmpty(internalCache) ? root.val.ToString() : $"->{root.val}";

            if (root.left != null)
            {
                BinaryTreePathsRecursive(root.left, internalCache);
            }

            if (root.right != null)
            {
                BinaryTreePathsRecursive(root.right, internalCache);
            }

            return;
        }

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            cache = new List<string>();

            if (root == null)
            {
                return cache;
            }
            BinaryTreePathsRecursive(root, string.Empty);
            return cache;
        }
    }
}
