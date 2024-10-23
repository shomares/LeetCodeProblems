using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IsSubstringPresentClass
    {
        public bool IsSubstringPresent(string s)
        {
            var index = s.Length - 1;
            var cache = new HashSet<string>();

            while (index - 1 >= 0)
            {
                cache.Add($"{s[index]}{s[index - 1]}");
                index--;
            }

            index = 0;

            while (index < s.Length - 1)
            {
                var key = $"{s[index]}{s[index + 1]}";

                if (cache.Contains(key))
                {
                    return true;
                }

                index++;
            }

            return false;

        }
    }
}
