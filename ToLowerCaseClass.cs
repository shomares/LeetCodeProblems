using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ToLowerCaseClass
    {
        public static string ToLowerCase(string s)
        {
            var array = s.ToCharArray();
            var index = 0;

            while (index < array.Length)
            {
                var c = array[index];

                if (c >= 65 && c <= 90)
                {
                    array[index] += (char)32; 
                }

                index++;
            }

            return new string(array);
        }
    }
}
