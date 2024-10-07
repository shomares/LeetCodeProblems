using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class GoatClass
    {
        public string ToGoatLatin(string sentence)
        {
            var splitted = sentence.Split(' ');
            var result = new StringBuilder();
            var index = 0;

            while (index < splitted.Length)
            {
                var word = splitted[index];
                var firstLetter = char.ToLower(word[0]);

                var isVowelR = isVowel(firstLetter);
                var indexj = isVowelR ? 0 : 1;

                while (indexj < word.Length)
                {
                    result.Append(word[indexj]);
                    indexj++;
                }

                if (isVowelR)
                {
                    result.Append("ma");
                }
                else
                {
                    result.Append(word[0]);
                    result.Append("ma");
                }

                for (var i = 1; i <= index + 1; i++)
                {
                    result.Append('a');
                }

                if(index < splitted.Length - 1)
                {
                    result.Append(' ');
                }
               
                index++;
            }

            return result.ToString();
        }

        private static bool isVowel(char firstLetter)
        {
            return firstLetter == 'a' || firstLetter == 'e' || firstLetter == 'i' || firstLetter == 'o' || firstLetter == 'u';
        }
    }
}
