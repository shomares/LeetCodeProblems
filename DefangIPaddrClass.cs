using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DefangIPaddrClass
    {
        public string DefangIPaddr(string address)
        {
            var result = new StringBuilder();



            foreach (var part in address)
            {
                if (part == '.')
                {
                    result.Append("[.]");
                }
                else
                {
                    result.Append(part);
                }
            }


            return result.ToString();

        }
    }
}
