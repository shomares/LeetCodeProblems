using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class GreatestLetterClass
    {
        public string GreatestLetter(string s)
        {
            var dic = new HashSet<char>(s);

            char? result = null;

            foreach (var entry in dic)
            {
                if (entry >= 'A' && entry <= 'Z')
                {
                    var lower = (char)(entry + 32);

                    if (dic.Contains(lower) && (result == null || result < entry))
                    {
                        result = entry;
                    }
                }
            }

            return result == null ? string.Empty : result.ToString();
        }
    }
}
