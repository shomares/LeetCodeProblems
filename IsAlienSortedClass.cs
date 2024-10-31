using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IsAlienSortedClass
    {
        public bool IsAlienSorted(string[] words, string order)
        {

            var dictionary = new Dictionary<char, int>();

            var index = 1;

            while (index <= order.Length)
            {

                dictionary.Add(order[index - 1], index);
                index++;
            }

            index = 1;


            while (index < words.Length)
            {
                var wordA = words[index - 1];
                var wordB = words[index];

                var indexj = 0;

                var charA = wordA[indexj];
                var charB = wordB[indexj];

                var toChangeA = dictionary[charA];
                var toChangeB = dictionary[charB];

                while (indexj < wordA.Length - 1 && indexj < wordB.Length - 1 && toChangeA == toChangeB)
                {
                    indexj++;
                    charA = wordA[indexj];
                    charB = wordB[indexj];
                    toChangeA = dictionary[charA];
                    toChangeB = dictionary[charB];
                }

                if (toChangeA > toChangeB)
                {
                    return false;
                }
                else if (toChangeA == toChangeB && wordA.Length > wordB.Length)
                {
                    return false;
                }


                index++;
            }


            return true;
        }
    }
}
