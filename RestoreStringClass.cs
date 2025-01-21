using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RestoreStringClass
    {
        public string RestoreString(string s, int[] indices)
        {
            var result = new char[s.Length];

            var index = 0;

            while (index < s.Length)
            {
                result[indices[index]] = s[index];
                index++;
            }



            return new string(result);
        }
    }
}
