using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    internal class Cookies
    {
        public static int FindContentChildren(int[] g, int[] s)
        {
            if (s == null || s.Length == 0 || g == null || g.Length == 0)
            {
                return 0;
            }
            Array.Sort(g);
            Array.Sort(s);
            int contentChildren = 0;
            int cookieIndex = 0;
            while (cookieIndex < s.Length && contentChildren < g.Length)
            {
                if (s[cookieIndex] >= g[contentChildren])
                {
                    contentChildren++;
                }

                cookieIndex++;
            }
            return contentChildren;
        }
    }
}
