using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreePreorderTraversal
    {

        public static IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            var stack = new Stack<TreeNode>();
            var lastFather = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Peek();

                if (lastFather.Count > 0)
                {
                    var lastF = lastFather.Peek();
                    if (node == lastF)
                    {
                        stack.Pop();
                        lastFather.Pop();
                        result.Add(node.val);
                        continue;
                    }
                }


                if (node.right != null)
                {
                    stack.Push(node.right);
                }

                if (node.left != null)
                {
                    stack.Push(node.left);
                }

                if (node.left == null && node.right == null)
                {
                    stack.Pop();
                    result.Add(node.val);
                }
                else
                {
                    lastFather.Push(node);
                }
            };


            return result;
        }

        public static IList<int> PreorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                result.Add(node.val);

                if (node.right != null)
                {
                    stack.Push(node.right);
                }

                if (node.left != null)
                {
                    stack.Push(node.left);
                }
            }

            return result;
        }
    }
}
