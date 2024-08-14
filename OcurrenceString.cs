using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class OcurrenceString
    {
        public static int StrStr(string haystack = "mississippi", string needle = "sippia")
        {
            if (haystack.Length < needle.Length)
            {
                return -1;
            }

            var index = 0;
            while (index < haystack.Length)
            {
                var charToCompare = haystack[index];

                if (charToCompare == needle[0])
                {
                    var result = ComparePortion(haystack, needle, index);
                    if (result >= 0)
                    {
                        return result;
                    }
                }

                index++;
            }

            return -1;
        }

        private static int ComparePortion(string haystack, string needle, int index)
        {
            var indexk = needle.Length - 1;
            var indexj = index + needle.Length - 1;

            if (indexj >= haystack.Length)
            {
                return -1;
            }

            while (indexk > 0)
            {
                var newChar = needle[indexk];
                var toCompare = haystack[indexj];

                if (toCompare != newChar)
                {
                    return -1;
                }

                indexk--;
                indexj--;
            }

            return index;
        }


    }
}
