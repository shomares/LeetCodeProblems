using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestCommonPrefixClass
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            var index = 1;

            var indexPrefix = 0;

            var firstStr = strs[0];
            var prefix = string.Empty;
            var result = string.Empty;


            while (indexPrefix < firstStr.Length)
            {
                prefix += firstStr[indexPrefix];

                while (index < strs.Length)
                {
                    var toCompare = strs[index];
                    if (indexPrefix >= toCompare.Length)
                    {
                        return result;
                    }

                    var prefixToCompare = toCompare[..(indexPrefix + 1)];

                    if (prefixToCompare != prefix)
                    {
                        return result;
                    }


                    index++;
                }

                index = 1;
                result = prefix;
                indexPrefix++;
            }

            return result;
        }
    }
}
