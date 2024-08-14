using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    internal class MaxProfitClass
    {

        public static int MaxProfit(int[] prices)
        {
            if(prices.Length == 0)
            {
                return 0;
            }
            var minValue = prices[0];
            var index = 0;
            var profit = 0;

            while (index < prices.Length)
            {
                if (minValue > prices[index])
                {
                    minValue = prices[index];
                }
                else
                {
                    var calculated = prices[index] - minValue;

                    if(profit < calculated)
                    {
                        profit = calculated;
                    }
                }

               

                index++;
            }

            return profit;

        }
    }
}
