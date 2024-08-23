using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Assistance
    {
        public static bool CheckRecord(string s)
        {

            if(string.IsNullOrEmpty(s)) return false;

            var index = 0;
            var numerOfMissings = 0;
            var numberOfLate = 0;

            while (index < s.Length)
            {
                var c = s[index];

                if (c == 'A')
                {
                    numerOfMissings++;
                }

                if (numerOfMissings > 1)
                {
                    return false;
                }

                while (index < s.Length && c == 'L')
                {
                    numberOfLate++;
                    if (index < s.Length - 1)
                    {
                        c = s[++index];
                    }
                    else
                    {
                        index++;
                    }

                }

                if (numberOfLate > 2)
                {
                    return false;
                }

                if(numberOfLate  == 0)
                {
                    index++;
                }

                numberOfLate = 0;
                
            }

            return true;
        }
    }
}
