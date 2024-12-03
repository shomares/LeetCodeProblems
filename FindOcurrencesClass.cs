using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class FindOcurrencesClass
	{
		public string[] FindOcurrences(string text, string first, string second)
		{
			var result = new List<string>();
			var splitted = text.Split();

			var index = 0;

			while (index < splitted.Length)
			{
				var word = splitted[index];

				if (word == first && (index + 1) < splitted.Length)
				{
					var secondToValidate = splitted[index + 1];
					if (secondToValidate == second && (index + 2) < splitted.Length)
					{
						result.Add(splitted[index + 2]);
					}

				}

				index++;

			}

			return [.. result];
		}
	}
}
