using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ThousandSeparatorClass
    {
        //1234
        public string ThousandSeparator(int n)
        {
            if(n == 0)
            {
                return "0";
            }
            var str = new Stack<char>();
            var counter = 0;
            var numberCopy = n;
            var index = 1;
            var factoAnt = 1;

            while (numberCopy > 0)
            {
                var factor = (int)Math.Pow(10, index);
                var toAdd = numberCopy % factor;
                numberCopy -= toAdd;
                var digit = toAdd / factoAnt;

                if (counter == 3)
                {
                    counter = 1;
                    str.Push('.');
                }
                else
                {
                    counter++;
                }

                str.Push((char)(digit + '0'));
                index++;
                factoAnt = factor;
            }



            return new string([..str]);
        }
    }
}
