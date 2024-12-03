using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class RemoveDuplicatesEasyClass
	{
		public string RemoveDuplicates(string s)
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

				var lastItem = stack.Peek();

				if (lastItem != c)
				{
					stack.Push(c);
				}
				else
				{
					stack.Pop();
				}

				index++;
			}

			var result = new char[stack.Count];
			index = stack.Count - 1;

			while (index >= 0)
			{
				result[index] = stack.Pop();
				index--;
			}

			return new string(result);
		}
	}
}
