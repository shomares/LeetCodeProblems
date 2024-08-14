using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class AddStringClass
    {
        public static string AddStrings(string num1 = "123", string num2 = "11")
        {
            if (string.IsNullOrEmpty(num1))
            {
                return num2;
            }

            if(string.IsNullOrEmpty(num2))
            {
                return num1;
            }

            string x;
            string y;

            if (num1.Length > num2.Length)
            {
                x = num1;
                y = num2;
            }
            else
            {
                x = num2;
                y = num1;
            }


        

            var resultBag = new Stack<int>();
            var index = 0;
            var carry = 0;

            while (index < y.Length)
            {
                var numberOfX = x[^(index + 1)];
                var numberOfY = y[^(index + 1)];

                var individualSum = int.Parse(numberOfX.ToString()) + int.Parse(numberOfY.ToString()) + carry;
                var caraterToAdd = individualSum>=10? individualSum % 10 : individualSum;
                carry = individualSum / 10;
                resultBag.Push(caraterToAdd);
                index++;
            }

            while (index < x.Length)
            {
                var numberMissed = x[^(index + 1)];
                var individualSum = int.Parse(numberMissed.ToString()) + carry;
                var caraterToAdd = individualSum >= 10 ? individualSum % 10 : individualSum;
                carry = individualSum / 10;
                resultBag.Push(caraterToAdd);
                index++;
            }

            if (carry > 0)
            {
                resultBag.Push(carry);
            }


            var result = new StringBuilder();

            while(resultBag.Count > 0)
            {
                var toAdd = resultBag.Pop();
                result.Append(toAdd);
            }

            return result.ToString();
        }
    }
}
