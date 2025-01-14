using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountLargestGroupClass
    {
        public int CountLargestGroup(int n)
        {
            var index = 1;
            var numbers = new Dictionary<int, int>();


            while (index <= n)
            {
                if (index <= 9)
                {
                    numbers[index] = 1;
                    index++;
                    continue;
                }

                var sumDigits = DivideInDigitsAndSum(index);


                if (numbers.TryGetValue(sumDigits, out int times))
                {
                    numbers[sumDigits] = ++times;
                }
                else
                {
                    numbers[sumDigits] = 1;
                }


                index++;
            }

            var maximunItems = int.MinValue;
            var result = 0;

            foreach (var key in numbers.Keys)
            {
                if (numbers[key] > maximunItems)
                {
                    maximunItems = numbers[key];
                    result = 1;

                }
                else if (numbers[key] == maximunItems)
                {
                    maximunItems = numbers[key];
                    result++;
                }
            }

            return result;
        }

        private static int DivideInDigitsAndSum(int num)
        {
            var numCopy = num;
            var index = 0;
            var result = 0;
            while (numCopy > 0)
            {
                var factor = Math.Pow(10, index);
                var toAdd = (int)(numCopy % factor);
                numCopy -= toAdd;
                var digit = (int)(toAdd / Math.Pow(10, index - 1));
                result += digit;
                index++;
            }

            return result;
        }
    }
}
