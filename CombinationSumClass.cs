using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CombinationSumClass
    {
        private IList<IList<int>> _combinations = new List<IList<int>>();

        private void CalculateCombination(int[] candidates, List<int> currentCombination, int start, int target)
        {
            if (target == 0)
            {
                _combinations.Add(new List<int>(currentCombination));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (candidates[i] > target)
                {
                    // No need to continue if the current number is greater than the remaining target
                    continue;
                }

                currentCombination.Add(candidates[i]);
                CalculateCombination(candidates, currentCombination, i, target - candidates[i]);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            _combinations.Clear();
            var currentCombination = new List<int>();
            CalculateCombination(candidates, currentCombination, 0, target);
            return _combinations;
        }

    }
}
