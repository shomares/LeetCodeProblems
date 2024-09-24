using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SearchBSTClass
    {
        public static TreeNode SearchBST(TreeNode root, int val)
        {

            while (root != null)
            {
                if (root.val == val)
                {
                    return root;
                }

                else if (val > root.val)
                {
                    root = root.right;
                }
                else if (val < root.val)
                {
                    root = root.left;
                }
            }

            return null;

        }
    }
}
