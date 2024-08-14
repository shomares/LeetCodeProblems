using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Anagram
    {
        public static bool IsAnagram(string s, string t)
        {
            var map = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!map.TryAdd(c, 1))
                {
                    map[c] = ++map[c];
                }
            }

            foreach(char c in t)
            {
               if (map.TryGetValue(c, out int value))
                {
                    map[c] = --value;

                    if(value == 0)
                    {
                        map.Remove(c);
                    }

                    if(value < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return map.Count == 0;
        }
    }
}
