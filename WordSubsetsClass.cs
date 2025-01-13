using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class WordSubsetsClass
    {
        //["amazon","apple","facebook","google","leetcode"]
        //["lo","eo"]
        public IList<string> WordSubsets(string[] words1, string[] words2)
        {
            var result = new List<string>();

            var counted = new Dictionary<char, int>();

            //["lo","eoo"]
            foreach (var word in words2)
            {
                var countedInWord2 = new Dictionary<char, int>();
                foreach (var c in word)
                {
                    if (countedInWord2.TryGetValue(c, out int value))
                    {
                        countedInWord2[c] = ++value;
                    }
                    else
                    {
                        countedInWord2[c] = 1;
                    }
                }


                foreach (var key in countedInWord2.Keys)
                {
                    if (counted.TryGetValue(key, out var value))
                    {
                        if (value < countedInWord2[key])
                        {
                            counted[key] = countedInWord2[key];
                        }
                    }
                    else
                    {
                        counted[key] = countedInWord2[key];
                    }

                }
            }

            //["amazon","apple","facebook","google","leetcode"]
            //["lo","eo"]
            //google,leetcode

            foreach (var word in words1)
            {
                var countedInWord1 = new Dictionary<char, int>();

                foreach (var c in word)
                {
                    if (countedInWord1.TryGetValue(c, out int value))
                    {
                        countedInWord1[c] = ++value;
                    }
                    else
                    {
                        countedInWord1[c] = 1;
                    }
                }

                var isValid = true;

                foreach (var key in counted.Keys)
                {
                    if (!countedInWord1.ContainsKey(key))
                    {
                        isValid = false;
                        break;
                    }

                    if (countedInWord1[key] < counted[key])
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    result.Add(word);
                }
            }

            return result;
        }
    }
}
