using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Anagrams
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dictionary = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                var charAux = str.ToCharArray();
                Array.Sort(charAux);
                var key = new string(charAux);

                if (dictionary.TryGetValue(key, out var list))
                {
                    list.Add(str);
                }
                else
                {
                    dictionary.Add(key, [str]);
                }
            }

            var s = dictionary.Values.ToList();
            return s;
            
        }
    }
}
