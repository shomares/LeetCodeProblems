using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class UniqueOccurrencesClass
    {
        //1,2,2,1,1,3
        public bool UniqueOccurrences(int[] arr)
        {
                var map = new Dictionary<int, int>();

                foreach (int i in arr)
                {
                    if (map.TryGetValue(i, out var value))
                    {
                        map[i] = ++value;
                    }
                    else
                    {
                        map[i] = 1;
                    }
                }

                var hashSet = new HashSet<int>();
                foreach (var entry in map)
                {
                    if (!hashSet.Add(entry.Value))
                    {
                        return false;
                    }
                }

                return true;
        }
    }
}
