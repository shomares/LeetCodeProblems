using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CombinationSumTwo
    {
        private bool isReached = false;
        private readonly IList<IList<int>> combinations = new List<IList<int>>();


        public void RecursiveCombinationSum2(int[] candidates, int carry, int target)
        {
            if (carry == target)
            {
                isReached = true;
                return;
            }

            for (var i = 0; i < candidates.Length; i++)
            {
                if (candidates[i] > target || candidates[i] == -1)
                {
                    continue;
                }

                RecursiveCombinationSum2(candidates, carry + candidates[i], target);

                if (isReached)
                {
                    candidates[i] = -1;
                }
            }
        }

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var result = new List<IList<int>>();



            return result;
        }
    }
}
