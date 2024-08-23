using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TildClass
    {
        private  int tild = 0;

        public  int FindTiltInternal(TreeNode root)
        {
            if (root == null) return 0;
            if(root.left == null && root.right == null)
            {
                return root.val;
            }

            
            var left = FindTiltInternal(root.left);
            var right = FindTiltInternal(root.right);
            tild += Math.Abs(left - right);
            var result = root.val + left + right;
            return result;
        }

        public  int FindTilt(TreeNode root)
        {
            tild = 0;
            FindTiltInternal(root);
            return tild;
        }
    }
}
