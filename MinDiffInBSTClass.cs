using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MinDiffInBSTClass
    {
        private int MinDiff = int.MaxValue;
        private int AntValue = int.MinValue;

        private void MinDiffInternal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            MinDiffInternal(root.left);

      
            if(AntValue != int.MinValue)
            {
                var diff = root.val - AntValue;
                MinDiff = int.Min(diff, MinDiff);
            }
         
            AntValue = root.val;
            MinDiffInternal(root.right);
        }


        public int MinDiffInBST(TreeNode root)
        {
            MinDiff = int.MaxValue;
            MinDiffInternal(root);
            return MinDiff==int.MinValue? 0: MinDiff;
        }
    }
}
