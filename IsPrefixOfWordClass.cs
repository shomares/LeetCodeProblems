using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IsPrefixOfWordClass
    {

        //i love eating burger
        //burg
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            var index = 0;
            var countEquals = 0;
            var result = 0;

            while (index < sentence.Length)
            {
                var c = sentence[index];

                if (c == ' ' || index == 0)
                {
                    result++;

                    if (index + 1 > sentence.Length)
                    {
                        return -1;
                    }

                    if (index > 0)
                    {
                        c = sentence[++index];
                    }

                    if (c != searchWord[0])
                    {
                        index++;
                        continue;
                    }

                    while (index < sentence.Length && countEquals < searchWord.Length)
                    {
                        c = sentence[index];

                        if (c != searchWord[countEquals])
                        {
                            break;
                        }

                        countEquals++;
                        index++;
                    }

                    if (countEquals == searchWord.Length)
                    {
                        return result;
                    }

                    countEquals = 0;

                    if (c == ' ')
                    {
                        index--;
                    }

                }



                index++;
            }

            return -1;
        }
    }
}
