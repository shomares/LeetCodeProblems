using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeDiameter
    {
        private  int Result = int.MinValue;

        private  int DiameterOfBinaryTreeInt(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = DiameterOfBinaryTreeInt(root.left);
            var right = DiameterOfBinaryTreeInt(root.right);
            var heigthMax = 1 + Math.Max(left, right);

            var diameter = left + right;

            if (diameter > Result)
            {
                Result = diameter;
            }

            return heigthMax;
        }

        public  int DiameterOfBinaryTree(TreeNode root)
        {
            Result = int.MinValue;
            DiameterOfBinaryTreeInt(root);
            return Result;
        }
    }
}
