using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseWordsClass
    {
        public static string ReverseWords(string s)
        {
            var indexi = 0;
            var indexj = 0;
            var charArray = s.ToCharArray();

            while (indexj <= charArray.Length)
            {
                var c = indexj < charArray.Length ? charArray[indexj] : ' ';

                //start to revert 
                if (c == ' ')
                {
                    var until = indexj - 1;
                    while (indexi < until)
                    {
                        (charArray[until], charArray[indexi]) = (charArray[indexi], charArray[until]);
                        indexi++;
                        until--;
                    }

                    indexi = indexj + 1;
                }

                indexj++;
            }

            return new string(charArray);
        }
    }
}
