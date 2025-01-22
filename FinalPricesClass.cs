using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FinalPricesClass
    {
        public int[] FinalPrices(int[] prices)
        {
            var result = new int[prices.Length];
            var stack = new Stack<int>();

            Array.Copy(prices, 0, result, 0, prices.Length);

            var index = 0;

            while (index < prices.Length)
            {
                var item = prices[index];

                while (stack.Count > 0 && item <= prices[stack.Peek()])
                {
                    var indexPeek = stack.Peek();
                    result[indexPeek] = prices[indexPeek] - item;
                    stack.Pop();
                }


                stack.Push(index);
                index++;
            }


            return result;
        }
    }
}
