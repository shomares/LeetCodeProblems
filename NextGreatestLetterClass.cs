using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NextGreatestLetterClass
    {
        public static char NextGreatestLetter(char[] letters, char target)
        {
            if (target > letters[^1])
            {
                return letters[0];
            }


            var left = 0;
            var rigth = letters.Length - 1;
            var middle = 0;

            while (left <= rigth)
            {
                middle = left + (rigth - left) / 2;

                if (letters[middle] == target)
                {
                    if (middle < letters.Length - 1 && letters[middle + 1] != target)
                    {
                        return letters[middle + 1];
                    }
                }

                if (letters[middle] > target)
                {
                    rigth = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            if (left > 0 && left <= letters.Length - 1)
            {
                return letters[left];
            }

            return letters[0];


        }
    }
}
