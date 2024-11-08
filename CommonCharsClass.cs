using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CommonCharsClass
    {


        public IList<string> CommonChars(string[] words)
        {
            var firstHash = new Dictionary<char, int>();

            var firstWord = words[0];

            foreach (var c in firstWord)
            {
                if (firstHash.TryGetValue(c, out int hash))
                {
                    firstHash[c] = ++hash;
                }
                else
                {
                    firstHash.Add(c, 1);
                }
            }

            var index = 1;

            while (index < words.Length)
            {
                var dc = new Dictionary<char, int>();
                var word = words[index];

                foreach (var c in word)
                {
                    if (firstHash.ContainsKey(c))
                    {
                        if (dc.TryGetValue(c, out int hash))
                        {
                            dc[c] = ++hash;
                        }
                        else
                        {
                            dc[c] = 1;
                        }
                    }
                }

                foreach (var hash in firstHash)
                {
                    if (dc.TryGetValue(hash.Key, out var value))
                    {
                        if(value < hash.Value)
                        {
                            firstHash[hash.Key] = value;
                        }

                        continue;
                    }
                    else
                    {
                        firstHash[hash.Key] = -1;
                    }

                }

                index++;
            }


            var result = new List<string>();

            foreach (var end in firstHash)
            {
                if (end.Value != -1)
                {
                    for (var i = 0; i < end.Value; i++)
                    {
                        result.Add(end.Key.ToString());
                    }
                }
            }

            return result;

        }
    }
}
