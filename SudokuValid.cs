using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SudokuValid
    {
        private static bool IsValidSqare(char[][] board)
        {

            var index = 0;
            var indexj = 0;

            var hashLeft = new HashSet<char>();
            var hashCenter = new HashSet<char>();
            var hashRight = new HashSet<char>();

            while (index < board.Length)
            {
                var array = board[index];

                while (indexj < array.Length)
                {
                    var value = array[indexj];

                    if(value == '.')
                    {
                        indexj++;
                        continue;
                    }

                    if (indexj < 3 && !hashLeft.Add(value))
                    {
                        return false;
                    }
                    else if (indexj >= 3 && indexj < 6 && !hashCenter.Add(value))
                    {
                        return false;
                    }
                    else if (indexj >= 6 && indexj < 9 && !hashRight.Add(value))
                    {
                        return false;
                    }

                    indexj++;
                }

                if (index > 0 && (index + 1) % 3 == 0)
                {
                    hashLeft.Clear();
                    hashCenter.Clear();
                    hashRight.Clear();
                }

                indexj = 0;
                index++;
            }
         
            return true;
        }

        public static bool IsValidSudoku(char[][] board)
        {
            var index = 0;
            var indexj = 0;

            while (index < board.Length)
            {
                //Validate arrayX ---
                var arrayX = board[index];
                var list = new HashSet<char>();

                foreach (var x in arrayX)
                {
                    if (x != '.')
                    {
                        if (!list.Add(x))
                        {
                            return false;
                        }
                    }
                }

                list.Clear();
                while (indexj < board.Length)
                {
                    var y = board[indexj][index];
                    if (y != '.')
                    {
                        if (!list.Add(y))
                        {
                            return false;
                        }
                    }

                    indexj++;
                }

                indexj = 0;
                index++;
            }


            return IsValidSqare(board);
        }
    }
}
