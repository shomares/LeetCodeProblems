using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class WordPatternClass
    {

        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            if (s.Length == 1)
            {
                return 1;
            }

            //Rate first item 
            var hash = new HashSet<char>();
            var indexi = 0;
            var max = 0;

            while (indexi < s.Length)
            {
                var charC = s[indexi];
                if (!hash.Add(charC))
                {
                    max = hash.Count;
                    if (hash.Count > 1)
                    {
                        var removeFirst = s[indexi - hash.Count];
                        hash.Remove(removeFirst);
                    }
                    break;
                }

                indexi++;
            }

            if (indexi == s.Length)
            {
                return indexi;
            }


            //Then just add to the final in hashset
            while (indexi < s.Length)
            {
                var charC = s[indexi];

                if (!hash.Add(charC))
                {
                    if (hash.Count > max)
                    {
                        max = hash.Count;
                    }

                    var removeFirst = s[indexi - hash.Count];
                    hash.Remove(removeFirst);

                }
                else
                {
                    indexi++;
                }


            }


            return Math.Max(max, hash.Count);
        }


        public static bool WordPattern(string pattern, string s)
        {
            var maped = new Dictionary<char, string>();
            var reverseMapped = new Dictionary<string, char>();
            var splitted = s.Split(' ');

            if (splitted.Length != pattern.Length)
            {
                return false;
            }

            var index = 0;

            while (index < pattern.Length)
            {
                var word = splitted[index];
                var charAux = pattern[index];
                char reversedV = ' ';

                if (!maped.TryGetValue(charAux, out string? value) && !reverseMapped.TryGetValue(word, out reversedV))
                {
                    maped.Add(charAux, word);
                    reverseMapped.Add(word, charAux);
                }
                else
                {
                    var patternValue = value;
                    var reversedValue = reversedV;
                    if (patternValue != word && reversedValue != charAux)
                    {
                        return false;
                    }
                }

                index++;
            }

            return true;
        }
    }
}
