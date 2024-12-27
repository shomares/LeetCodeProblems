using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    internal class RemoveAnagramsClass
    {
        public IList<string> RemoveAnagrams(string[] words)
        {
            var response = new List<string>();
            var dic = new HashSet<string>();
            string ant = string.Empty;

            foreach (var word in words)
            {
                var array = word.ToCharArray();
                Array.Sort(array);
                var key = new string(array);

                if (dic.Contains(key) && ant == key)
                {
                    continue;
                }

                dic.Add(key);
                response.Add(word);
                ant = key;
            }

            return response;
        }



    }
}
