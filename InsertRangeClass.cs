using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class InsertRangeClass
    {
        private int GetPosition(int[][] intervals, int start, int end, int toFind)
        {
            var result = 0;
            while (start <= end)
            {
                result = start + (end - start) / 2;

                var value = intervals[result][0];

                if (value == toFind)
                {
                    return result;
                }
                else if (value > toFind)
                {
                    end = result - 1;
                }
                else
                {
                    start = result + 1;
                }


            }

            return result;

        }

        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var result = new List<int[]>();
            var positionLeft = GetPosition(intervals, 0, intervals.Length - 1, newInterval[0]);
            var positionRight = GetPosition(intervals, positionLeft, intervals.Length - 1, newInterval[1]);

            var index = 0;

            while (index < intervals.Length)
            {
                var aux = intervals[index];

                if (aux[0] > newInterval[0] && aux[1] < newInterval[1])
                {
                    result.Add(aux);
                }
                else
                {

                }

                index++;
            }



            return result.ToArray();
        }
    }
}
