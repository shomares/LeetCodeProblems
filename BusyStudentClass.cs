using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class BusyStudentClass
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            var result = 0;
            var index = 0;

            while (index < endTime.Length)
            {
                if (startTime[index] >= queryTime && endTime[index] >= queryTime)
                {
                    result++;
                }

                index++;
            }

            return result;
        }
    }
}
