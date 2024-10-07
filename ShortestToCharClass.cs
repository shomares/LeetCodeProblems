using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ShortestToCharClass
    {

        public int[] ShortestToChar(string s, char c)
        {
            var result = new int[s.Length];
            var index = 0;
            var left = -1;

            while (index < s.Length)
            {
                if (s[index] == c || index == s.Length - 1)
                {
                    var indexj = index;
                    while (indexj >= 0 && indexj >= left)
                    {
                        var minLeft = Math.Abs(indexj - left);
                        var minRight = Math.Abs(indexj - index);

                        if (index == s.Length - 1 && s[index] != c)
                        {
                            result[indexj] = minLeft;
                        }
                        else if (left > -1)
                        {
                            result[indexj] = Math.Min(minLeft, minRight);
                        }

                        else
                        {
                            result[indexj] = minRight;
                        }

                        indexj--;
                    }

                    left = index;
                }


                index++;
            }


            return result;
        }
    }
}
