using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TwoSumBST
    {
        private readonly List<int> cache = [];

        private void InternalCaching(TreeNode? root)
        {
            if (root == null) return;

            InternalCaching(root.left);
            cache.Add(root.val);
            InternalCaching(root.right);

        }

        public bool FindTarget(TreeNode root, int k)
        {
            cache.Clear();
            InternalCaching(root);

            var left = 0;
            var right = cache.Count -1;

            if(left == right)
            {
                return false;
            }

            while (left < right)
            {
                var valueLeft = cache[left];
                var valueRight = cache[right];

                var sum = valueLeft + valueRight;

                if (sum == k)
                {
                    return true;
                }
                else if (sum > k)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return false;
        }
    }
}
