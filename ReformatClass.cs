using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReformatClass
    {
        public string Reformat(string s = "j")
        {
            var index = 0;

            var letters = new Stack<char>();
            var numbers = new Stack<char>();

            while (index < s.Length)
            {
                var c = s[index];

                if (char.IsDigit(c))
                {
                    letters.Push(c);
                }
                else
                {
                    numbers.Push(c);
                }

                index++;

            }

            var difference = letters.Count - numbers.Count;

            if (difference < -1 || difference > 1)
            {
                return string.Empty;
            }

            //Calculate first stack
            Stack<char> firstStack;
            Stack<char> secondStack;

            if (letters.Count > numbers.Count)
            {
                firstStack = letters;
                secondStack = numbers;
            }
            else
            {
                firstStack = numbers;
                secondStack = letters;
            }

            if (firstStack.Count == 1 && secondStack.Count == 0)
            {
                return string.Empty;
            }

            var result = new StringBuilder();

            while (secondStack.Count > 0)
            {
                result.Append($"{firstStack.Pop()}{secondStack.Pop()}");
            }

            if (firstStack.Count > 0)
            {
                result.Append(firstStack.Pop());
            }

            return result.ToString();
        }
    }
}
