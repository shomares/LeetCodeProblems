using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountDistinctIntegersClass
    {
        public int GetSize(int num)
        {
            var n = 10;
            var result = 0;
            while (num > 0)
            {
                var digit = num % n;
                num -= digit;
                n *= 10;
                result++;
            }

            return result;
        }


        public int RevertInteger(int num = 280)
        {

            var size = GetSize(num);
            var nSize = size;

            if (size == 1)
            {
                return num;
            }

            var n = 10;
            var divisor = 1;
            var result = 0;
            while (num > 0)
            {
                var digit = num % n;
                var newDigit = digit / divisor;

                num -= digit;
                divisor = n;
                n *= 10;

                if (nSize == size && newDigit == 0)
                {
                    nSize--;
                    continue;
                }

                result += newDigit * (int)Math.Pow(10, nSize - 1);
                nSize--;
            }

            return result;
        }

        public int CountDistinctIntegers(int[] nums)
        {
            var hashset = new HashSet<int>(nums);
            foreach (int num in nums)
            {
                var reverse = RevertInteger(num);
                hashset.Add(reverse);
            }


            return hashset.Count;
        }
    }
}
