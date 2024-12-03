using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class DistributeCandiesClass
	{
		public int[] DistributeCandies(int candies, int num_people)
		{
			var result = new int[num_people];

			var sumTotal = 0;
			var indexk = 1;

			while (sumTotal < candies)
			{
				for (int i = 1; i <= num_people && sumTotal < candies; i++)
				{
					var toAdd = result[i - 1] + indexk;
					var rest = candies - (sumTotal - result[i - 1]);

					if (toAdd <= rest)
					{
						result[i - 1] = toAdd;
					}
					else
					{
						result[i - 1] = rest;
					}

					sumTotal += indexk;
					indexk++;
				}

			}

			return result;
		}
	}
}
