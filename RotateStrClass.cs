using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class NeighborhoodChar
    {
        public char Left { get; set; }

        public char Medium { get; set; }
        public char Right { get; set; }

    }

    internal class RotateStrClass
    {
        public static bool RotateString(string s, string goal)
        {
            if (s.Length != goal.Length)
            {
                return false;
            }

            var dictionary = new Dictionary<char, List<NeighborhoodChar>>();

            var index = 0;

            while (index < s.Length)
            {
                NeighborhoodChar item;
                var c = s[index];
                if (index == 0)
                {
                    item = new NeighborhoodChar
                    {
                        Left = s[^1],
                        Right = s[index + 1],
                        Medium = c
                    };
                }
                else if (index == s.Length - 1)
                {
                    item = new NeighborhoodChar
                    {
                        Left = s[index - 1],
                        Right = s[0],
                        Medium = c
                    };

                }
                else
                {
                    item = new NeighborhoodChar
                    {
                        Left = s[index - 1],
                        Right = s[index + 1],
                        Medium = c
                    };
                }

                if (dictionary.TryGetValue(c, out var list))
                {
                    list.Add(item);
                }
                else
                {

                    dictionary.Add(c, [item]);
                }

                index++;
            }

            index = 0;

            while (index < goal.Length)
            {
                var c = goal[index];
                char left, right;


                if (index == 0)
                {
                    left = goal[^1];
                    right = goal[index + 1];
                }
                else if (index == s.Length - 1)
                {
                    left = goal[index - 1];
                    right = goal[0];
                }
                else
                {
                    left = goal[index - 1];
                    right = goal[index + 1];
                }

                var validate = 0;

                if (dictionary.TryGetValue(c, out var values))
                {
                
                    foreach (var v in values)
                    {
                        if (v.Left == left && v.Right == right)
                        {
                            validate++;
                        }
                    }
                }


                if (validate == 0)
                {
                    return false;
                }

                index++;
            }


            return true;
        }
    }
}
