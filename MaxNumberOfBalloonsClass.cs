using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaxNumberOfBalloonsClass
    {
        //balloon
        public int MaxNumberOfBalloons(string text)
        {
            var hashmap = new HashSet<char>("ballon");

            var index = 0;

            var dictonionaryByWord = new Dictionary<char, int>();

            while (index < text.Length)
            {
                var c = text[index];

                if (hashmap.Contains(c))
                {
                    if (dictonionaryByWord.TryGetValue(c, out var value))
                    {
                        dictonionaryByWord[c] = ++value;
                    }
                    else
                    {
                        dictonionaryByWord.Add(c, 1);
                    }
                }

                index++;
            }

            if (!(dictonionaryByWord.ContainsKey('b')
                && dictonionaryByWord.ContainsKey('a')
                && dictonionaryByWord.ContainsKey('l')
                && dictonionaryByWord.ContainsKey('o')
                && dictonionaryByWord.ContainsKey('n'))
                )
            {
                return 0;
            }

            //balloon
            var numberOfB = dictonionaryByWord['b'];
            var numberOfA = dictonionaryByWord['a'];
            var numberOfL = dictonionaryByWord['l'];
            var numberOfO = dictonionaryByWord['o'];
            var numberOfN = dictonionaryByWord['n'];

            if (numberOfL < 2 || numberOfO < 2)
            {
                return 0;
            }

            var minNumberOf = Math.Min(numberOfN, Math.Min(numberOfB, numberOfA));



            return Math.Min(numberOfL / 2, Math.Min(minNumberOf, numberOfO / 2));
        }
    }
}
