using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class NodePassed : Node
    {
        public NodePassed(Node node, NodePassed parent = null)
        {
            this.children = node.children;
            this.val = node.val;
            this.Counted = node.children == null ? 0 : node.children.Count;
            this.Parent = parent;
        }

        public int Counted { get; set; }

        public NodePassed? Parent { get; set; }
    }

    internal class MaxDepthNode
    {
        public static int MaxDepth(Node root)
        {
            if (root == null) return 0;

            if (root.children == null || root.children.Count == 0)
                return 1;

            var maxDepth = int.MinValue;
            foreach (Node child in root.children)
            {
                var depth = 1 + MaxDepth(child);

                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }

            }

            return maxDepth;
        }

        public static IList<int> Preorder(Node root)
        {
            if (root == null) return new List<int>();

            var result = new List<int>() { root.val };

            if (root.children == null || root.children.Count == 0)
            {
                return result;
            }


            var stack = new Stack<Node>();
            var index = root.children.Count - 1;

            while (index >= 0)
            {
                stack.Push(root.children[index]);
                index--;
            }


            while (stack.Count > 0)
            {
                var item = stack.Pop();
                result.Add(item.val);

                if (item.children != null)
                {
                    index = item.children.Count - 1;
                    while (index >= 0)
                    {
                        stack.Push(item.children[index]);
                        index--;
                    }

                }
            }


            return result;

        }


        public static IList<int> Postorder(Node root)
        {
            if (root == null) return new List<int>();

            var result = new List<int>();
            var stack = new Stack<NodePassed>([new NodePassed(root)]);

            while (stack.Count > 0)
            {
                var item = stack.Peek();

                if (item.Counted == 0)
                {
                    if (item.Parent != null)
                    {
                        item.Parent.Counted--;
                    }

                    result.Add(item.val);
                    stack.Pop();

                }

                else if (item.children != null && item.children.Count > 0)
                {
                    var index = item.children.Count - 1;
                    while (index >= 0)
                    {
                        stack.Push(new NodePassed(item.children[index], item));
                        index--;
                    }
                }
            }

            return result;

        }



    }
}
