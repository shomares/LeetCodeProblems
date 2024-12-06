using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CanBeTypedWordsClass
    {
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            var splited = text.Split(' ');

            var hashed = new HashSet<char>(brokenLetters);

            var result = 0;
            bool isCorrect;

            foreach (var word in splited)
            {
                isCorrect = true;
                foreach (var c in word)
                {
                    if (hashed.Contains(c))
                    {
                        isCorrect = false;
                        break;
                    }
                }

                if (isCorrect)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
