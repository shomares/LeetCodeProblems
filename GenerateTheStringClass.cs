using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class GenerateTheStringClass
    {
        public string GenerateTheString(int n)
        {
            var str = new StringBuilder();
            var index = 0;

            var top = n % 2 == 0 ? n - 1 : n;

            while (index < top)
            {
                str.Append('a');
                index++;
            }

            if (n % 2 == 0)
            {
                str.Append('b');
            }

            return str.ToString();

        }
    }
}
