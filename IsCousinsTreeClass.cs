using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IsCousinsTreeClass
    {
        private TreeNode[] parents = new TreeNode[2];
        private int?[] height = new int?[2];

        private void ToFindNode(TreeNode node, TreeNode? parent, int x, int param)
        {
            if (node == null) return;

            if (node.val == x)
            {
                height[param] = 0;
                parents[param] = parent;
                return;
            }

            if (height[param] == null)
            {
                ToFindNode(node.left, node, x, param);
            }

            if (height[param] == null)
            {
                ToFindNode(node.right, node, x, param);
            }

            if (height[param] != null)
            {
                height[param]++;
            }
        }



        public bool IsCousins(TreeNode root, int x, int y)
        {
            height = new int?[2];
            parents = new TreeNode[2];
            ToFindNode(root, null, x, 0);
            ToFindNode(root, null, y, 1);

            if (height[0] == null || height[1] == null)
            {
                return false;
            }

            if (parents[0] == null)
            {
                return false;
            }

            return height[0] == height[1] && parents[0] != parents[1];
        }
    }
}
