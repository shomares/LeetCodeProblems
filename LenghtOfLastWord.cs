using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LenghtOfLastWordClass
    {
        public static int LengthOfLastWord(string s = "a")
        {
            var index = s.Length - 1;
            var result = 0;

            while (index >= 0)
            {
                var charValue = s[index];

                if(charValue != ' ')
                {
                    while (index>=0 && s[index]!= ' ')
                    {
                        result++;
                        index--;
                    }

                    return result;
                }

                index--;
            }

            return result;
        }
    }
}
