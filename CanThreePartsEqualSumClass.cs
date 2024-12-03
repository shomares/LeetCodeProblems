using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class CanThreePartsEqualSumClass
	{

		public bool CanThreePartsEqualSum(int[] arr)
		{
			var sum = arr.Sum();

			if (sum % 3 != 0)
			{
				return false;
			}

			var top = sum / 3;
			var index = 0;
			var sumT = 0;
			var counter = 0;

			var zeroscount = 0;

			while (index < arr.Length)
			{
				sumT += arr[index];

				if (arr[index] == 0)
				{
					zeroscount++;
				}

				if (sumT == top)
				{
					sumT = 0;
					counter++;
				}

				index++;
			}

			if (sum == 0 && zeroscount == arr.Length)
			{
				return true;
			}

			return counter >= 3;

		}
	}
}
