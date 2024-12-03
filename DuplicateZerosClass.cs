using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class DuplicateZerosClass
	{
		//[1,0,2,3,0,4,5,0]
		//[1,0,0,2,3,0,0,4]

		public void DuplicateZeros(int[] arr)
		{
			var index = 0;

			while (index < arr.Length)
			{
				var value = arr[index];

				if (value == 0)
				{
					//duplicate and shift right
					DuplicateAndShiftRight(arr, index);
					index++;
				}

				index++;
			}
		}

		//[1,0,2,3,0,4,5,0]
		//[1,0,0,2,3,0,0,4]

		private static void DuplicateAndShiftRight(int[] arr, int index)
		{
			var indexk = index;
			var aux = 0;
			while (indexk + 1 < arr.Length)
			{
				var aux2 = arr[indexk + 1];
				arr[indexk + 1] = aux;
				aux = aux2;
				indexk++;
			}
		}
	}
}
