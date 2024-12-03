using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class RelativeSortArrayClass
	{
		public int[] RelativeSortArray(int[] arr1, int[] arr2)
		{
			var result = new int[arr1.Length];
			var dictionary = new SortedDictionary<int,int>();
		
			foreach (var i in arr1)
			{
				if (dictionary.TryGetValue(i, out var s))
				{
					dictionary[i] = ++s;
				}
				else
				{
					dictionary.Add(i, 1);
				}
			}

			var indexk = 0;
			var index = 0;
			while (indexk < arr2.Length)
			{
				var key = arr2[indexk];
				if (dictionary.TryGetValue(key, out var s))
				{
					for (var i = 0; i < s; i++)
					{
						result[index] = key;
						index++;
					}

					dictionary.Remove(key);
				}

				indexk++;

			}

			foreach (var entry in dictionary)
			{
				var key = entry.Key;
				var items = entry.Value;
				for (var i = 0; i < items; i++)
				{
					result[index] = key;
					index++;
				}
			}


			return result;
		}
	}
}
