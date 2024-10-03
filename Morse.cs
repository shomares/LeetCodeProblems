using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Morse
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            Dictionary<char, string> code = new Dictionary<char, string>(){
                    {'a', ".-"}, {'b', "-..."}, {'c', "-.-."}, {'d', "-.."}, {'e', "."}, {'f', "..-."}, {'g', "--."}, {'h', "...."}, {'i', ".."}, {'j', ".---"}, {'k', "-.-"}, {'l', ".-.."}, {'m', "--"}, {'n', "-."}, {'o', "---"}, {'p', ".--."}, {'q', "--.-"}, {'r', ".-."}, {'s', "..."}, {'t', "-"}, {'u', "..-"}, {'v', "...-"}, {'w', ".--"}, {'x', "-..-"}, {'y', "-.--"}, {'z', "--.."}, };

            var hash = new HashSet<string>();

            foreach (string word in words)
            {
                var str = new StringBuilder();
                foreach (char c in word)
                {
                    if (code.TryGetValue(c, out var s))
                    {
                        str.Append(s);
                    }
                }

                hash.Add(str.ToString());
            }



            return hash.Count;
        }

    }
}
