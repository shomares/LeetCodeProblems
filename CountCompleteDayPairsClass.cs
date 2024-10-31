using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountCompleteDayPairsClass
    {
        public int CountCompleteDayPairs(int[] hours)
        {
            var i = 0;
            var result = 0;
            var cache = new HashSet<string>();
            while (i < hours.Length)
            {
                var valueL = hours[i];
                var j = 0;

                while (j < hours.Length)
                {
                    if (j == i)
                    {
                        j++;
                        continue;
                    }


                    var valueR = hours[j];
                    var sum = valueL + valueR;

                    if (sum % 24 == 0 && cache.Add($"{(i > j ? i : j)}-{(i > j ? j : i)}"))
                    {

                        result++;
                    }

                    j++;
                }

                i++;
            }

            return result;
        }
    }
}
