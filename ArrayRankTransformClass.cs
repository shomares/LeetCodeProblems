using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ArrayRankTransformClass
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            var sortedArray = new int[arr.Length];

            var index = 0;

            while (index < arr.Length)
            {
                sortedArray[index] = arr[index];
                index++;
            }

            Array.Sort(sortedArray);

            var dic = new Dictionary<int, int>();
            index = 0;

            var indexj = 1;

            while (index < sortedArray.Length)
            {
                if(index == 3)
                {
                    Console.WriteLine(arr[index]);
                }

                if (!dic.ContainsKey(sortedArray[index]))
                {
                    dic.Add(sortedArray[index], indexj);
                    indexj++;
                }
                
                index++;
            }

            index = 0;

            while (index < arr.Length)
            {
                arr[index] = dic[arr[index]];
                index++;
            }


            return arr;
        }
    }
}
