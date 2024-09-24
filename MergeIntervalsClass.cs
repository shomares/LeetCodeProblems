using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MergeIntervalsClass
    {

        private static void Quicksort(int[][] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central][0];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i][0] < pivote) i++;
                while (vector[j][0] > pivote) j--;
                if (i <= j)
                {
                    (vector[j], vector[i]) = (vector[i], vector[j]);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                Quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                Quicksort(vector, i, ultimo);
            }
        }

        public static int[][] Merge(int[][] intervals)
        {
            //Sort intervals
            Quicksort(intervals, 0, intervals.Length - 1);

            var result = new List<int[]>();

            var index = 0;

            while (index < intervals.Length)
            {
                var item = intervals[index];
                if (result.Count == 0)
                {
                    result.Add(item);
                }
                else
                {

                    var lastItem = result[^1];
                    if (item[0] <= lastItem[1])
                    {
                        lastItem[1] = item[1] > lastItem[1] ? item[1] : lastItem[1];
                    }
                    else
                    {
                        result.Add(item);
                    }
                }

                index++;
            }


            return [.. result];
        }
    }
}
