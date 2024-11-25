using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RemoveOuterParenthesesClass
    {
        public string RemoveOuterParentheses(string s = "(()())(())")
        {
            var stack = new Stack<char>();
            var index = 0;
            var strP = new StringBuilder();
            var resultStr = new StringBuilder();
            var j = 0;

            while (index < s.Length)
            {
                var c = s[index];

                if (c == '(')
                {
                    stack.Push(c);
                }
                else
                {
                    stack.Pop();
                }

                if (j > 0 && stack.Count > 0)
                {
                    strP.Append(c);
                }

                j++;


                //Primitive value
                if (index > 0 && stack.Count == 0)
                {
                    j = 0;
                    resultStr.Append(strP);
                    strP.Clear();
                }

                index++;
            }

            return resultStr.ToString();
        }
    }
}
