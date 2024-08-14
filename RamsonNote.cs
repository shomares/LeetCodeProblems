using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RamsonNote
    {
        private class RamsonNoteAux
        {
            public int Value { get; set; }
            public int Index { get; set; }
        }


        public static int FirstUniqChar(string s)
        {
            var hashMap = new Dictionary<char, RamsonNoteAux>();
            var index = 0;

            foreach (char c in s)
            {
                if (hashMap.TryGetValue(c, out RamsonNoteAux? value))
                {
                    value.Value++;
                }
                else
                {
                    hashMap.Add(c, new RamsonNoteAux
                    {
                        Index = index,
                        Value = 1
                    });
                }

                index++;
            }

            foreach (var (_, ramsonNote) in hashMap)
            {
                if (ramsonNote.Value == 1)
                {
                    return ramsonNote.Index;
                }
            }

            return -1;
        }


        public static bool CanConstruct(string ransomNote, string magazine)
        {
            var hashmap = new Dictionary<char, int>();

            foreach (char c in magazine)
            {
                if (hashmap.TryGetValue(c, out int value))
                {
                    hashmap[c] = ++value;
                }
                else
                {
                    hashmap.Add(c, 1);
                }
            }

            foreach (var r in ransomNote)
            {
                if (!hashmap.TryGetValue(r, out int value) || value <= 0)
                {
                    return false;
                }

                hashmap[r]--;
            }

            return true;
        }

        private static int SumStr(string s)
        {
            int output = 0;
            foreach (var c in s)
            {
                output += c;
            }

            return output;
        }

        public static char FindTheDifference(string s, string t)
        {
            var sumS = SumStr(s);
            var tS = SumStr(t);

            var result = (int)Math.Abs(sumS - tS);
            return (char)result;
        }

        public static bool IsSubsequence(string s, string t)
        {
            if (s.Length > t.Length)
            {
                return false;
            }

            var indexs = 0;
            var indext = 0;

            while (indexs < s.Length && indext < t.Length)
            {
                var chars = s[indexs];
                var chart = t[indext];

                if (chars == chart)
                {
                    indexs++;
                    indext++;
                }
                else
                {
                    indext++;
                }
            }

            return indexs == s.Length;
        }

    }
}
