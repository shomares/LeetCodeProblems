using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseStrClass
    {
        public static string ReverseStr(string s, int k)
        {
            if (k >= s.Length)
            {
                k = s.Length;
            }

            var charArray = s.ToCharArray();

            var index = 0;
            var subsStrLenght = 1;
            var indexj = 0;
            var toApply = true;

            while (indexj < charArray.Length)
            {
                if (subsStrLenght == k || indexj == charArray.Length - 1)
                {
                    var lastItem = indexj;
                    //Start to change
                    while (toApply && index <= indexj)
                    {
                        (charArray[indexj], charArray[index]) = (charArray[index], charArray[indexj]);
                        index++;
                        indexj--;
                    }

                    index = lastItem + 1;
                    indexj = index;
                    subsStrLenght = 1;
                    toApply = !toApply;
                }
                else
                {
                    subsStrLenght++;
                    indexj++;
                }


            }


            return new string(charArray);
        }

    }
}
