using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Permutation
    {
        readonly IList<IList<int>> _permutations = new List<IList<int>>();


        private void Analize(IList<int> cache, IList<int> availables, int count, int size)
        {
            if (size == count)
            {
                _permutations.Add(cache);
                return;
            }

            foreach (var item in availables)
            {
                var copyAvailables = new List<int>(availables);
                copyAvailables.Remove(item);
                Analize(new List<int>([..cache, item]), copyAvailables, count + 1, size);
            }

        }


        public IList<IList<int>> Permute(int[] nums)
        {
            _permutations.Clear();

            Analize(new List<int>(), nums.ToList(), 0, nums.Length);
            return _permutations;
        }
    }
}
