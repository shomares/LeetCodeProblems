using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ModifyStringClass
    {
        public string ModifyString(string s = "??pqr?s??")
        {
            var str = new char[s.Length];

            var index = 0;


            while (index < s.Length)
            {
                var c = s[index];

                if (c != '?')
                {
                    str[index] = c;
                    index++;
                    continue;
                }

              
                char? ant = index > 0 ? str[index - 1] : null;
                char? next = index == s.Length - 1 ? null : s[index + 1];
                var toAdd = 'a';

                while (ant == toAdd || next == toAdd)
                {
                    toAdd++;
                    if (toAdd == 123)
                    {
                        toAdd = 'a';
                    }
                }

                str[index] = toAdd;
                index++;
            }

            return new string(str);

        }
    }
}
