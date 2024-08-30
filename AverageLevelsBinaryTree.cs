using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class AverageLevelsBinaryTree
    {

        public static IList<double> AverageOfLevels(TreeNode root)
        {
            var result = new List<double>();

            var stack = new Stack<TreeNode>();
            stack.Push(root);


            while (stack.Count > 0)
            {
                var sum = 0.0d;
                var items = 0;
                var itemCache = new List<TreeNode>();

                while (stack.Count > 0)
                {
                    var node = stack.Pop();
                    sum += node.val;
                    items++;

                    if (node.left != null)
                    {
                        itemCache.Add(node.left);
                    }

                    if (node.right != null)
                    {
                        itemCache.Add(node.right);
                    }

                }

                result.Add(sum / items);
                stack = new Stack<TreeNode> (itemCache);
            }

            return result;
        }
    }
}
