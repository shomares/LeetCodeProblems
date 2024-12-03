using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class SumZeroClass
	{
		public int[] SumZero(int n)
		{
			var result = new int[n];

			var index = 0;
			var indexj = n - 1;

			while (index < indexj)
			{
				result[index] = -(indexj + 1);
				result[indexj] = (indexj + 1);
				index++;
				indexj--;
			}

			if (n % 2 != 0)
			{
				result[index] = 0;
			}

			return result;
		}
	}
}
