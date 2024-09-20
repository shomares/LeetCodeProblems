using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ShortestCompletingWordClass
    {
        public  string ShortestCompletingWord(string licensePlate, string[] words)
        {
            var index = 0;
            var hashmap = new Dictionary<char, int>();

            while (index < licensePlate.Length)
            {
                var c = licensePlate[index];

                if (char.IsLetter(c))
                {
                    if (hashmap.TryGetValue(char.ToLower(c), out var ocurrences))
                    {
                        hashmap[char.ToLower(c)]++;
                    }
                    else
                    {
                        hashmap.Add(char.ToLower(c), 1);
                    }
                }

                index++;
            }

            var result = string.Empty;
            var minValue = int.MaxValue;

            index = 0;

            while (index < words.Length)
            {
                var indexj = 0;
                var word = words[index];
                var hashInt = new Dictionary<char, int>();

                while (indexj < word.Length)
                {
                    if (hashmap.ContainsKey(word[indexj]))
                    {
                        if (hashInt.TryGetValue(word[indexj], out int value))
                        {
                            hashInt[word[indexj]] = ++value;
                        }
                        else
                        {
                            hashInt.Add(word[indexj], 1);
                        }
                    }

                    indexj++;
                }

                if (minValue > word.Length && ValidateDictionaries(hashmap, hashInt))
                {
                    result = word;
                    minValue= word.Length;
                }

                index++;
            }

            return result;

        }

        private  bool ValidateDictionaries(Dictionary<char, int> hashmap, Dictionary<char, int> hashInt)
        {
            if (hashInt.Count != hashmap.Count)
            {
                return false;
            }

            if (hashInt.Count == hashmap.Count)
            {
                foreach (var valuePair in hashmap)
                {
                    if (hashInt[valuePair.Key] < hashmap[valuePair.Key])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
