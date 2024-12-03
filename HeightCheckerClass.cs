using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class HeightCheckerClass
	{
		public int HeightChecker(int[] heights)
		{
			var sorted = new int[heights.Length];
			var index = 0;

			foreach (var height in heights)
			{
				sorted[index] = height;
				index++;
			}

			Array.Sort(sorted);

			index = 0;
			var result = 0;

			while (index < sorted.Length)
			{
				var height = heights[index];
				var sort = sorted[index];

				if (height != sort)
				{
					result++;
				}

				index++;

			}

			return result;
		}
	}
}
