using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReplaceElementsEasyClass
    {
        //17,18,5,4,6,1
        //18,6,6,6,1,-1
        public int[] ReplaceElements(int[] arr)
        {
            var max = -1;
            var index = arr.Length - 1;

            while (index >= 0)
            {
                var element = arr[index];
                arr[index] = max;

                if(element> max)
                {
                    max = element;
                }

                index--;
            }

            return arr;
        }
    }
}
