using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RelativeRanks
    {
        public static string[] FindRelativeRanks(int[] score)
        {
            var result = new string[score.Length];
            var hashmap = new Dictionary<int, int>();
            var medals = new Dictionary<int, string> {
                {1, "Gold Medal" },
                {2, "Silver Medal" },
                {3, "Bronze Medal" },

            };

            var index = 0;

            foreach (int i in score)
            {
                hashmap.Add(i, index);
                index++;
            }

            Array.Sort(score);

            index = score.Length - 1;
            while (index >= 0)
            {
                var scoreValue = score[index];

                if (hashmap.TryGetValue(scoreValue, out var position))
                {
                    var relative = score.Length - index;
                    result[position] = medals.TryGetValue(relative, out string? value) ? value : relative.ToString();
                }

                index--;
            }


            return result;

        }
    }
}
