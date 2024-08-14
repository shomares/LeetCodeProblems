using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaximunLength
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root != null)
            {
                return Math.Max(1 + MaxDepth(root.left), 1 + MaxDepth(root.right));
            }

            return 0;
        }
    }
}
