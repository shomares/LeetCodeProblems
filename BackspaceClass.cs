//Review backspaces-------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class BackspaceClass
    {
        public bool BackspaceCompare(string s, string t)
        {
            var stackS = new Stack<char>();
            var stackT = new Stack<char>();

            var index = 0;
            while (index < s.Length)
            {
                var c = s[index];

                if (c != '#')
                {
                    stackS.Push(c);
                }
                else
                {
                    if (stackS.Count > 0)
                    {
                        stackS.Pop();
                    }

                }

                index++;
            }

            index = 0;

            while (index < t.Length)
            {
                var c = t[index];

                if (c != '#')
                {
                    stackT.Push(c);
                }
                else
                {
                    if (stackT.Count > 0)
                    {
                        stackT.Pop();
                    }

                }

                index++;
            }


            if (stackT.Count != stackS.Count)
            {
                return false;
            }

            while (stackS.Count > 0 && stackT.Count > 0)
            {
                var c = stackS.Pop();
                var c1 = stackT.Pop();

                if (c != c1)
                {
                    return false;
                }
            }

            return true;
        }


    }
}
