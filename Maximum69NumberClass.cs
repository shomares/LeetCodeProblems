using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Maximum69NumberClass
    {
        public int Maximum69Number(int num)
        {
            var array = new List<int>();
            var index = 1;
            var numCopy = num;

            while (numCopy > 0)
            {
                var factor = Math.Pow(10, index);
                var toAdd = (int)(numCopy % factor);
                numCopy -= toAdd;
                array.Add((int)(toAdd / Math.Pow(10, index - 1)));
                index++;
            }

            index = array.Count - 1;
            var result = 0;
            var hasChanged = false;

            while (index >= 0)
            {
                if (array[index] == 6 && !hasChanged)
                {
                    array[index] = 9;
                    hasChanged = true;
                }

                result += (int)(array[index] * Math.Pow(10, index ));

                index--;
            };

            return result;
        }
    }
}
