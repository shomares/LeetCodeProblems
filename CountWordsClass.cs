using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountWordsClass
    {
        public int CountWords(string[] words1, string[] words2)
        {
            var hashmap1 = CreateHashMap(words1);
            var hashmap2 = CreateHashMap(words2);
            var count = 0;

            foreach (var word in hashmap1)
            {

                if (hashmap2.Contains(word))
                {
                    count++;
                }
            }

            return count;
        }

        private static HashSet<string> CreateHashMap(string[] words1)
        {
            var hashmap = new HashSet<string>();
            var result = new HashSet<string>();

            foreach (string word in words1)
            {
                if (hashmap.Contains(word))
                {
                    result.Remove(word);
                }
                else
                {
                    hashmap.Add(word);
                    result.Add(word);
                    
                }
            }

            return result;
        }
    }
}
