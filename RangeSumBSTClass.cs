using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RangeSumBSTClass
    {

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return 0;
            }

            // Si el valor del nodo está dentro del rango, sumamos su valor
            if (root.val >= low && root.val <= high)
            {
                return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
            }
            // Si el valor del nodo es menor que low, descartamos el subárbol izquierdo
            else if (root.val < low)
            {
                return RangeSumBST(root.right, low, high);
            }
            // Si el valor del nodo es mayor que high, descartamos el subárbol derecho
            else
            {
                return RangeSumBST(root.left, low, high);
            }
        }

    }
}
