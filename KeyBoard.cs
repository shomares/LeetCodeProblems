using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class KeyBoard
    {
        public static string[] FindWords(string[] words)
        {
            var hashmapOne = new HashSet<char>("qwertyuiop");
            var hashmapTwo = new HashSet<char>("asdfghjkl");
            var hashmapTree = new HashSet<char>("zxcvbnm");
            var result = new List<string>();

            HashSet<char> firstSet = hashmapOne;

            foreach (var word in words)
            {
                var index = 0;

                bool isValid = true;

                while (isValid && index < word.Length)
                {

                    var c = char.ToLower(word[index]);

                    if (index == 0)
                    {
                        if (hashmapOne.Contains(c))
                        {
                            firstSet = hashmapOne;
                        }
                        else if (hashmapTwo.Contains(c))
                        {
                            firstSet = hashmapTwo;
                        }
                        else if (hashmapTree.Contains(c))
                        {
                            firstSet = hashmapTree;
                        }
                    }
                    else
                    {
                        if (!firstSet.Contains(c))
                        {
                            isValid = false;
                        }

                    }

                    index++;
                }

                if (isValid)
                {
                    result.Add(word);
                }
            }

            return [..result];
        }
    }
}
