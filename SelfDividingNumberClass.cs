using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SelfDividingNumberClass
    {
        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            var list = new List<int>();
            var index = left;

            while (index <= right)
            {
                if (IsSelfDividingNumber(index))
                {
                    list.Add(index);
                }

                index++;
            }

            return list;
        }

        private static bool IsSelfDividingNumber(int number)
        {
            var numberStr = number.ToString();

            foreach(var c in numberStr)
            {
                if(c == '0')
                {
                    return false;
                }

                if(number % int.Parse(c.ToString()) != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
