using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ContainsPatternClass
    {
        //[1,2,3,1,2]
        //m=2 k=2
        public bool ContainsPattern(int[] arr, int m, int k)
        {


            int count = m;

            for (int i = 0; i < arr.Length - m; i++)
            {
                if (arr[i] == arr[i + m])
                {
                    count++;
                }
                else
                {
                    count = m;
                }

                if (count / m >= k)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
