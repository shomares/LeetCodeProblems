using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeBSD
    {
        static bool hasSumPath = false;

        public static void HasPathSumRecursive(TreeNode root, int sum, int targetSum)
        {
            if (root == null) return;

            sum += root.val;

            if (sum == targetSum && root.left == null && root.right == null)
            {
                hasSumPath = true;
                return;
            }

            if (!hasSumPath && root.left != null )
            {
                HasPathSumRecursive(root.left, sum, targetSum);
            }

            if (!hasSumPath && root.right != null)
            {
                HasPathSumRecursive(root.right, sum, targetSum);
            }
        }

        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            hasSumPath = false;
            HasPathSumRecursive(root, 0, targetSum);
            return hasSumPath;

        }

        public static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null)
            {
                return 1 + MinDepth(root.right);
            }

            if (root.right == null)
            {
                return 1 + MinDepth(root.left);
            }

            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }

        public static int IsBalancedRecursive(TreeNode? root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = 1 + IsBalancedRecursive(root.left);
            var right = 1 + IsBalancedRecursive(root.right);

            var rate = Math.Abs(left - right);

            if (rate > 1)
            {
                throw new Exception();
            }

            return Math.Max(left, right);
        }


        public static bool IsBalanced(TreeNode root)
        {
            try
            {
                IsBalancedRecursive(root);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static TreeNode? SortedBst(int height, int top, int[] nums)
        {
            if (height > nums.Length || top < 0 || height < top || top == nums.Length)
            {
                return null;
            }

            if (height == 0)
            {
                return new TreeNode(nums[0]);
            }

            if (top == height)
            {
                return new TreeNode(nums[top]);
            }

            int middle = top + (height - top) / 2;
            var pivot = nums[middle];

            var node = new TreeNode(pivot);

            node.left = SortedBst(middle - 1, top, nums);
            node.right = SortedBst(height, middle + 1, nums);

            return node;
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedBst(nums.Length, 0, nums);

        }
    }
}
