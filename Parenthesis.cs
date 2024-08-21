using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Parenthesis
    {
        private static List<string> list = new List<string>();
        private static void CreateAllPaths(string cache, int n)
        {
            if (n == 0)
            {
                if (ValidateIsClosed(cache))
                {
                    list.Add(cache);
                }
               
                return;
            }

            CreateAllPaths($"{cache}(", n - 1);
            CreateAllPaths($"{cache})", n - 1);

        }

        private static bool ValidateIsClosed(string s)
        {
            var stack = new Stack<char>();
            int index = 0;

            while (index < s.Length)
            {
                var charValue = s[index];

                if (charValue == '{' || charValue == '(' || charValue == '[')
                {
                    stack.Push(charValue);
                }
                else
                {
                    if (stack.TryPeek(out var value))
                    {
                        if (
                          (value == '{' && charValue == '}') ||
                          (value == '(' && charValue == ')') ||
                          (value == '[' && charValue == ']')
                      )
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }


                index++;
            }


            return stack.Count == 0 && s.Length > 1;

        }

        public static IList<string> GenerateParenthesis(int n)
        {
            list.Clear();
            CreateAllPaths("(", (n * 2) - 1);
            return list;
        }
    }
}
