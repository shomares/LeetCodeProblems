using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SecondMinimunValue
    {
        private readonly SortedSet<int> values = new SortedSet<int>();

        private void RecorreInOrden(TreeNode? node)
        {
            if (node == null) return;

            RecorreInOrden(node.left);
            values.Add(node.val);
            RecorreInOrden(node.right);
        }


        public int FindSecondMinimumValue(TreeNode root)
        {
            values.Clear();
            RecorreInOrden(root);

            if(values.Count <= 1) return -1;

            return values.ToArray()[1];
          
        }
    }
}
