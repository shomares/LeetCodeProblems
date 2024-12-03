using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class TrimMeanClass
	{
		public double TrimMean(int[] arr)
		{
			int toRemove;
			if (arr.Length < 20)
			{
				toRemove = 1;
			}
			else
			{
				toRemove = (int)(arr.Length * 0.05);
			}

			var index = toRemove;
			var top = arr.Length - toRemove;
			var sum = 0.0d;
			var count = 0;

			Array.Sort(arr);

			while (index < top)
			{
				sum += arr[index];
				count++;
				index++;

			}

			return sum / count;
		}
	}
}
