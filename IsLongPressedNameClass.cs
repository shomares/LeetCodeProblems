using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IsLongPressedNameClass
    {
        public bool IsLongPressedName(string name, string typed)
        {
            int len1 = name.Length;
            int len2 = typed.Length;
            int idx1 = 0;
            int idx2 = 0;
            char prev = name[0];
            char c2 = typed[0];
            char c1 = prev;
            while (idx1 < len1 && idx2 < len2)
            {
                c1 = name[idx1];
                c2 = typed[idx2];
                if (c1 == c2)
                {
                    idx1++;
                    idx2++;
                    prev = c1;
                }
                else if (c2 == prev)
                {
                    idx2++;
                }
                else
                {
                    return false;
                }
            }
            while (idx2 < len2)
            {
                c2 = typed[idx2];
                if (c2 != c1)
                {
                    return false;
                }

                idx2++;
            }
            return idx1 == len1 && idx2 == len2;
        }
    }
}
