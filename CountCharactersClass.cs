using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountCharactersClass
    {

        private int CountCharacterFromWord(string word, IDictionary<char, int> items)
        {
            var result = 0;
            var internalDictionary = new Dictionary<char, int>();

            foreach (var item in word)
            {
                if (items.TryGetValue(item, out var count))
                {

                    if (!internalDictionary.TryGetValue(item, out var countInt))
                    {
                        internalDictionary.Add(item, 1);

                    }
                    else if (count - countInt <= 0)
                    {
                        return 0;
                    }
                    else
                    {
                        internalDictionary[item] = ++countInt;
                    }

                    result++;
                }
                else
                {
                    return 0;
                }

            }

            return result;
        }

        public int CountCharacters(string[] words, string chars)
        {
            var dictonary = new Dictionary<char, int>();
            var result = 0;

            foreach (var c in chars)
            {
                if (dictonary.TryGetValue(c, out var count))
                {
                    dictonary[c] = ++count;
                }
                else
                {
                    dictonary.Add(c, 1);
                }
            }

            foreach (var w in words)
            {
                result += CountCharacterFromWord(w, dictonary);
            }


            return result;
        }
    }
}
