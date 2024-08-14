using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Pascal
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();

            for (var index = 0; index < numRows; index++)
            {
                IList<int> list = CalcultateRow(index, result);
                result.Add(list);
            }

            return result;
        }

        private static List<int> CalcultateRow(int index, List<IList<int>> cache)
        {
            if (index == 0)
            {
                return [1];
            }

            if (index == 1)
            {
                return [1, 1];
            }

            var result = new List<int>() { 1 };
            var rowPrevious = cache[index - 1];

            var indexJ = 1;

            while (indexJ < rowPrevious.Count)
            {
                var sum = rowPrevious[indexJ] + rowPrevious[indexJ - 1];
                result.Add(sum);
                indexJ++;
            }

            result.Add(1);
            return result;

        }
    }
}
