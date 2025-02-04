using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReorderSpacesClass
    {
        public string ReorderSpaces(string text = " practice   makes   perfect")
        {
            var numberOfSpaces = 0;
            var words = new List<string>();
            var result = new char[text.Length];

            var index = 0;

            while (index < text.Length)
            {
                result[index++] = ' ';
            }

            index = 0;
            var word = new StringBuilder();

            while (index < text.Length)
            {
                var c = text[index];

                if (c == ' ')
                {
                    numberOfSpaces++;

                    if (word.Length > 0)
                    {
                        words.Add(word.ToString());
                        word.Clear();
                    }
                }
                else
                {
                    word.Append(c);
                }

                index++;
            }

            if (word.Length > 0)
            {
                words.Add(word.ToString());
            }

            var numberOfSpacesBtw = words.Count > 1 ?
                    numberOfSpaces / (words.Count - 1) :
                    result.Length - words[0].Length;


            index = 0;
            var indexW = 0;

            while (index < result.Length && indexW < words.Count)
            {
                var indexk = 0;
                var wordToAdd = words[indexW];

                while (indexk < wordToAdd.Length)
                {
                    result[index] = wordToAdd[indexk++];
                    index++;
                }

                if (index < result.Length)
                {
                    for (indexk = 0; indexk < numberOfSpacesBtw && index < result.Length; indexk++)
                    {
                        result[index] = ' ';
                        index++;
                    }
                }

                indexW++;
            }


            return new string(result);

        }
    }
}
