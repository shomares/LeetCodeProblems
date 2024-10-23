using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NumRescueBoatsClass
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);

            var count = 0;
            var start = 0;
            var end = people.Length - 1;

            while (start < end)
            {
                if (people[end] == limit)
                {
                    count++;
                    end--;
                    continue;
                }


                var sum = people[start] + people[end];

                if (sum <= limit)
                {
                    count++;
                    start++;
                    end--;
                }
                else
                {
                    if (people[end] <= limit)
                    {
                        count++;
                        end--;
                    }
                }
            }

            if (start == end && people[end] <= limit)
            {
                count++;
            }

            return count;
        }
    }
}
