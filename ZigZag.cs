using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ZigZag
    {
        public static string Convert(string s, int numRows)
        {
            var matrix = new List<char[]>();
            var up = false;

            var index = 0;
            var indexj = 0;
            var page = 0;

            if(numRows <= 1)
            {
                return s;
            }

            while (index < s.Length)
            {
                var row = page;
                if (matrix.Count <= row)
                {
                    matrix.Add(new char[numRows]);
                }

                var factor = index == 0 ? numRows : numRows - 1;

                while (index + indexj < s.Length && indexj < factor)
                {
                    var charToAdd = s[index + indexj];
                    if (!up)
                    {
                        matrix[row][row == 0 ? indexj : indexj + 1] = charToAdd;
                    }
                    else
                    {
                        matrix[row][numRows - (indexj + 2)] = charToAdd;
                    }

                    indexj++;
                }

                up = !up;
                page++;
                index += indexj;
                indexj = 0;
            }




            return TransformMatrixToString(matrix, numRows);
        }

        private static string TransformMatrixToString(List<char[]> matrix, int numRows)
        {
            var indexj = 0;
            var indexi = 0;
            var result = new StringBuilder();

            while(indexi < numRows)
            {
                while (indexj < matrix.Count)
                {
                    var charToAdd = matrix[indexj][indexi];

                    if(charToAdd != 0)
                    {
                        result.Append(charToAdd);
                    }

                    indexj++;
                }

                indexj = 0;
                indexi++;
            }

            return result.ToString();
          

        }
    }
}
