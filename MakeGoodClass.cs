using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MakeGoodClass
    {
        //leEeetcode
        public string MakeGood(string s)
        {
            var stack = new Stack<char>();
            var index = 0;

            while (index < s.Length)
            {
                var c = s[index];

                if (stack.Count == 0)
                {
                    stack.Push(c);
                    index++;
                    continue;
                }

                var peek = stack.Peek();
                var firstItem = char.ToLower(peek);
                var toCompare = char.ToLower(c);

                if (firstItem == toCompare && c != peek)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }


                index++;
            }

            var str = new string([.. stack]);
            if (stack.Count < 1)
            {
                return str;
            }

            var result = new char[str.Length];
            index = 0;

            while (index < str.Length)
            {
                result[index] = str[(str.Length - 1) - index];
                index++;
            }



            return new string(result);
        }
    }
}
