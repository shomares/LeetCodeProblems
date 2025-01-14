using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class StringMatchingClass
    {
        public IList<string> StringMatching(string[] words)
        {
            var result = new HashSet<string>();
            var hashSet = new HashSet<string>(words);

            foreach (var word in hashSet)
            {

                foreach (var word2 in hashSet)
                {
                    if (word == word2)
                    {
                        continue;
                    }

                    if (word.Length > word2.Length)
                    {
                        continue;
                    }

                    if (word2.Contains(word))
                    {
                        result.Add(word);
                    }
                }
            }

            return result.ToList();
        }
    }
}
