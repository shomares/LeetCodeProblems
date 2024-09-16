using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MinumunIndex
    {

        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            var dictionary = new Dictionary<string, int>();
            var result = new List<string>();

            for (int i = 0; i < list1.Length; i++)
            {
                dictionary.Add(list1[i], i);
            }

            var minimunValue = int.MaxValue;
            var indexj = 0;
            foreach (var item in list2)
            {
                if (dictionary.TryGetValue(item, out var index))
                {
                    var sum = index + indexj;

                    if (sum < minimunValue)
                    {
                        result.Clear();
                        minimunValue = sum;
                    }

                    if(sum == minimunValue)
                    {
                        result.Add(item);
                    }
                }

                indexj++;
            }

            return [..result];
        }
    }
}
