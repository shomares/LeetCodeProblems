using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LeafSimilarClass
    {
        private readonly IList<int> valuesRoot1 = new List<int>();

        public void LeafSimilarAux(TreeNode? root1)
        {
            if (root1 == null) return;

            if (root1.left == null && root1.right == null)
            {
                valuesRoot1.Add(root1.val);
            }

            LeafSimilarAux(root1.left);

            LeafSimilarAux(root1.right);

        }


        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            valuesRoot1.Clear();
            LeafSimilarAux(root1);

            var valuesFromOne = valuesRoot1.ToArray();

            valuesRoot1.Clear();
            LeafSimilarAux(root2);

            var valuesFromSecond = valuesRoot1.ToArray();

            if (valuesFromOne.Length != valuesFromSecond.Length)
            {
                return false;
            }

            var index = 0;

            while(index < valuesFromOne.Length)
            {
                var currentA = valuesFromOne[index];
                var currentB = valuesFromSecond[index]; 

                if(currentA != currentB)
                {
                    return false;
                }

                index++;
            }


            return true;
        }
    }
}
