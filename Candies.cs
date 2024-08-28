using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    internal class Candies
    {

        public static int DistributeCandies(int[] candyType)
        {
            Array.Sort(candyType);
            var numItems = 0;
            var index = 0;
            var ant = -1;
            
            while(index < candyType.Length)
            {
                var num = candyType[index];

                if(num != ant)
                {
                    numItems++;
                }

                ant = num;
                index++;
            }

            var numItemsCanEat = candyType.Length / 2;
            return Math.Min(numItems, numItemsCanEat);


        }
    }
}
