using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DestCityClass
    {

        public string DestCity(IList<IList<string>> paths)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var path in paths)
            {
                var start = path[0];
                var end = path[1];
                dictionary.Add(start, end);
            }

            //Select first one start end
            var first = dictionary.First().Value;

            while (dictionary.ContainsKey(first))
            {
                first = dictionary[first];
            }
            return first;
        }
    }
}
