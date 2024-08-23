using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CapitalsWords
    {
        public static bool DetectCapitalUse(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            var index = 0;
            var indexj = word.Length - 1;
            var hasTobeAllUpper = false;

            while (index <= indexj)
            {
                while (word[index] == ' ' && index < word.Length)
                {
                    index++;
                }

                while (indexj >= 0 && word[indexj] == ' ')
                {
                    indexj--;
                }

                char c = word[index];
                char cF = word[indexj];

                var isUpperC = char.IsUpper(c);
                var isUpperCF = char.IsUpper(cF);


                if (index == 0 && isUpperC && !isUpperCF)
                {
                    hasTobeAllUpper = false;
                }

                else if (index == 0 && isUpperC && isUpperCF)
                {
                    hasTobeAllUpper = true;
                }
                else if (index > 0 && isUpperC != isUpperCF)
                {
                    return false;
                }
                else if (hasTobeAllUpper && (!isUpperC || !isUpperCF))
                {
                    return false;
                }else if(!hasTobeAllUpper && (isUpperC || isUpperCF))
                {
                    return false;
                }

                index++;
                indexj--;
            }

            return true;
        }
    }
}
