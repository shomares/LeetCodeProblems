using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaxScoreClass
    {
        public int MaxScore(string s = "011101")
        {
            var maxScore = int.MinValue;
            var numberOfOnes = 0;

            foreach (var c in s)
            {
                if (c == '1')
                {
                    numberOfOnes++;
                }
            }

            var numberOfZeros = 0;
            var index = 0;

            while (index < s.Length - 1)
            {
                var c = s[index];

                if (c == '1')
                {
                    numberOfOnes--;
                }
                else
                {
                    numberOfZeros++;
                }

                maxScore = Math.Max(numberOfOnes + numberOfZeros, maxScore);
                index++;
            }

            maxScore = Math.Max(numberOfOnes + numberOfZeros, maxScore);

            return maxScore;
        }
    }
}
