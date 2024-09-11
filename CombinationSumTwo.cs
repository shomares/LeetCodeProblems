using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CombinationSumTwo
    {
        private readonly HashSet<string> _cache = [];
        private readonly HashSet<string> _cacheAll = [];
        private readonly IList<IList<int>> _combinations = new List<IList<int>>();


        private void CalculateCombination(int[] candidates, int lastNumber, List<int> currentCombination, int start, int target)
        {
            if (target == 0)
            {
                StringBuilder str = CalculateKey(currentCombination);

                if (_cache.Add(str.ToString()))
                {
                    //Validate if exists in cache
                    _combinations.Add(new List<int>(currentCombination));
                    return;
                }


            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (candidates[i] > target || candidates[i] < lastNumber)
                {
                    continue;
                }

                currentCombination.Add(candidates[i]);
                var key = CalculateKey(currentCombination);

                if (_cacheAll.Add(key.ToString()))
                {
                    CalculateCombination(candidates, candidates[i], currentCombination, i + 1, target - candidates[i]);
                }

                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }

        private static StringBuilder CalculateKey(List<int> currentCombination)
        {
            var str = new StringBuilder();
            foreach (var combination in currentCombination)
            {
                str.Append(combination);
            }

            return str;
        }

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            _cacheAll.Clear();
            _combinations.Clear();
            _cache.Clear();
            var currentCombination = new List<int>();
            CalculateCombination(candidates, -1, currentCombination, 0, target);
            return _combinations;
        }
    }
}
