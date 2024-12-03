using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class NumberOfLinesClass
	{
		public int[] NumberOfLines(int[] widths, string s)
		{
			var index = 0;
			var numberOfRows = 0;
			var sizeOfRowTemp = 0;
			var lastSize = 0;

			while (index < s.Length)
			{
				var c = s[index];
				int valueOfIndex = GetValueOfIndex(c);

				var size = sizeOfRowTemp + widths[valueOfIndex];

				if (size < 100)
				{
					lastSize = size;
					sizeOfRowTemp = size;
					index++;

					if (index == s.Length)
					{
						numberOfRows++;
					}

				}
				else if (size == 100)
				{
					lastSize = size;
					numberOfRows++;
					sizeOfRowTemp = 0;
					index++;
				}
				else
				{
					numberOfRows++;
					sizeOfRowTemp = 0;
				}
			}

			return [numberOfRows, lastSize];
		}

		private int GetValueOfIndex(char c) =>
			 c - 97;

	}
}
