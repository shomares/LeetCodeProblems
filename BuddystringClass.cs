using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class BuddystringClass
    {
        public bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length)
            {
                return false;
            }


            if (s == goal)
            {
                var dictionary = new Dictionary<char, int>();

                foreach (char c in s)
                {
                    if (dictionary.TryGetValue(c, out int value))
                    {
                        dictionary[c] = value + 1;
                    }
                    else
                    {
                        dictionary.Add(c, 1);
                    }
                }

                var result = false;

                foreach (var key in dictionary.Keys)
                {
                    if (dictionary.TryGetValue(key, out int value) && value >= 2)
                    {
                        result = true;
                        break;
                    }
                }

                return result;
            }

            var index = 0;


            var hashset = new HashSet<string>();
            var missmatches = 0;

            var dictionaryMissMatchS = new Dictionary<char, int>();
            var dictionaryMissMatchG = new Dictionary<char, int>();

            while (index < goal.Length)
            {
                var c = s[index];
                var c1 = goal[index];

                if (dictionaryMissMatchS.TryGetValue(c, out var value))
                {
                    dictionaryMissMatchS[c] = value + 1;
                }
                else
                {
                    dictionaryMissMatchS.Add(c, 1);
                }

                if (dictionaryMissMatchG.TryGetValue(c1, out var value2))
                {
                    dictionaryMissMatchG[c1] = value2 + 1;
                }
                else
                {
                    dictionaryMissMatchG.Add(c1, 1);
                }


                if (c != c1)
                {
                    missmatches++;
                    var key = c1 > c ? $"{c1}{c}" : $"{c}{c1}";
                    if (hashset.Count() == 0)
                    {
                        hashset.Add(key);
                    }
                    else
                    {
                        if (!hashset.Add(key))
                        {
                            hashset.Remove(key);
                        }
                    }
                }

                index++;
            }

            if (missmatches != 2)
            {
                return false;
            }

            if (dictionaryMissMatchG.Count != dictionaryMissMatchS.Count)
            {
                return false;
            }


            foreach (var key in dictionaryMissMatchS)
            {
                if (!dictionaryMissMatchG.ContainsKey(key.Key))
                {
                    return false;
                }

                if (dictionaryMissMatchS[key.Key] != dictionaryMissMatchG[key.Key])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
