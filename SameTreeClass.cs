using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SameTreeClass
    {

        public static int CalculateLeftHeigth(TreeNode root)
        {
            if (root.left == null) return 0;
            int result = 0;

            while (root != null)
            {
                result++;
                root = root.left;
            }

            return result;
        }

        public static int CalculateRightHeigth(TreeNode root)
        {
            if (root.right == null) return 0;
            int result = 0;

            while (root != null)
            {
                result++;
                root = root.right;
            }

            return result;
        }

        public static int CountNodes(TreeNode root)
        {
            if (root == null) return 0;

            var leftH = CalculateLeftHeigth(root);
            var rightH = CalculateRightHeigth(root);

            if (leftH == rightH && leftH > 0)
            {
                return (int)(Math.Pow(2, leftH) - 1);
            }

            return 1 + CountNodes(root.right) + CountNodes(root.left);
        }


        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p != null && q != null && p.val == q.val)
            {
                var validateLeft = IsSameTree(p.left, q.left);
                if (!validateLeft)
                {
                    return false;
                }

                var validateRight = IsSameTree(p.right, q.right);
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
    }
}
