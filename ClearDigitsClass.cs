using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ClearDigitsClass
    {

        public string ClearDigits(string s)
        {
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (char.IsDigit(c) && stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            var result = new char[stack.Count];
            var index = result.Length - 1;

            while (index >= 0)
            {
                result[index] = stack.Pop();
                index--;
            }



            return new string(result);
        }
    }
}
