using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SumRootToLeafClass
    {
        private int? result = null;

        private int ConvertBinToDecimal(string bin)
        {
            var result = 0;
            var pow = 0;

            var index = bin.Length - 1;

            while (index >= 0)
            {
                var aux = bin[index];

                if (aux == '1')
                {
                    result += (int)Math.Pow(2, pow);
                }

                pow++;
                index--;
            }

            return result;
        }

        public void FindPaths(TreeNode root, string path)
        {
            
            if (root.left == null && root.right == null)
            {
                var decimalV = ConvertBinToDecimal($"{path}{root.val}");
                result += decimalV;
                return;
            }

            if(root.left != null)
            {
                FindPaths(root.left, $"{path}{root.val}");
            }
          
            if(root.right != null)
            {
                FindPaths(root.right, $"{path}{root.val}");
            }
           
        }

        public int SumRootToLeaf(TreeNode root)
        {
            result = 0;
            FindPaths(root, string.Empty);
            return result.Value;

        }
    }
}
