using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindModeBinary
    {

        private int frequency = 0;
        private int frequencyAnt = 0;
        private int? ant = null;
        private IList<int> result = new List<int>();

        private void InOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.left);

            //Get the same logic than in array
            if (ant == root.val)
            {
                frequency++;
            }
            else
            {
                if (frequencyAnt < frequency)
                {
                    frequencyAnt = frequency;
                    result.Clear();
                    result.Add(ant ?? root.val);
                }
                else if (frequency == frequencyAnt)
                {
                    result.Add(ant ?? root.val);
                }

                frequency = 1;
            }

            ant = root.val;
            InOrder(root.right);

        }


        public int[] FindMode(TreeNode root)
        {
            result.Clear();
            frequency = 0;
            frequencyAnt = 0;
            ant = null;

            InOrder(root);

            if (ant == null)
            {
                return [.. result];
            }

            if (frequencyAnt < frequency)
            {
                result.Clear();
                result.Add(ant.Value);
            }
            else if (frequencyAnt == frequency)
            {
                result.Add(ant.Value);
            }


            return [.. result];
        }
    }
}
