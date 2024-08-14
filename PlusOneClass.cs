using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PlusOneClass
    {
        public static int[] PlusOne(int[] digits)
        {
            var index = digits.Length - 1;
            var carry = 0;
            var stack = (int[])digits.Clone();

            while (index >= 0)
            {
                var resultSimple = index == digits.Length - 1 ? digits[index] + 1 : digits[index] + carry;
                if (resultSimple == digits[index])
                {
                    break;
                }

                stack[index] = resultSimple % 10;
                carry = resultSimple / 10;
                index--;
            }



            if (carry > 0)
            {
                return [carry, ..stack];
            }


            return stack;
        }
    }
}
