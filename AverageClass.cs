using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class AverageClass
    {
        
        public double Average(int[] salary)
        {
            var result = 0.0d;

            Array.Sort(salary);

            var index = 1;

            while (index < salary.Length - 1)
            {
                result += salary[index++];
            }


            var s = result / (salary.Length - 2);

            return s;

        }
    }
}
