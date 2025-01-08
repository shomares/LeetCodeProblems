using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DivisorSubstringsClass
    {
        public int DivisorSubstrings(int num, int k)
        {
            var strNum = num.ToString();
            var beauty = 0;
            var index = 0;

            var firstStr = string.Empty;

            while (index < k)
            {
                firstStr += strNum[index];
                index++;
            }

            if (int.TryParse(firstStr, out var valuef) && valuef != 0 && num % valuef == 0)
            {
                beauty++;
            }

            while (index < strNum.Length)
            {
                firstStr = firstStr.Remove(0, 1);
                firstStr += strNum[index];

                if (int.TryParse(firstStr, out var value) && value != 0 && num % value == 0)
                {
                    beauty++;
                }

                index++;
            }

            return beauty;
        }
    }
}
