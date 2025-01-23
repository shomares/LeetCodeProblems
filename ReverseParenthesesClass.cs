using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseParenthesesClass
    {
        public string ReverseParenthe(string s = "(u(love)i)")
        {
            var result = new StringBuilder();
            var index = 0;

            while (index < s.Length)
            {
                var c = s[index];

                if (c != '(')
                {
                    result.Append(c);
                    index++;
                    continue;
                }

                var stack = new Stack<char>();


                while (index < s.Length)
                {
                    c = s[index];

                    if (c != ')')
                    {
                        stack.Push(c);
                        index++;
                        continue;
                    }

                    var strb = new StringBuilder();
                    do
                    {

                        c = stack.Pop();
                        if (c != '(')
                        {
                            strb.Append(c);
                        }

                    } while (c != '(' && stack.Count > 0);

                    var str = strb.ToString();

                    if (stack.Count == 0)
                    {
                        result.Append(str);
                        break;
                    }

                    var indexS = 0;

                    while (indexS < str.Length)
                    {
                        stack.Push(str[indexS++]);
                    }

                    index++;
                }

                index++;
            }

            return result.ToString();

        }


    }
}
