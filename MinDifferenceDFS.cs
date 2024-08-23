using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MinDifferenceDFS
    {

        private  int aux = int.MaxValue;
        private  int min = int.MaxValue;

        public  void GetMinimumDifferenceRec(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            GetMinimumDifferenceRec(root.left);
            var num = root.val;
            if (aux != int.MaxValue)
            {
                var difference = Math.Abs(aux - num);
                min = Math.Min(min, difference);
            }

            aux = num;
            GetMinimumDifferenceRec(root.right);

        }

        public  int GetMinimumDifference(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return 0;
            }

            aux = int.MaxValue;
            min = int.MaxValue;
            GetMinimumDifferenceRec(root);
            return min;
        }

    }
}
