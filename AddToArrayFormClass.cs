using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class AddToArrayFormClass
    {
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            var result = new Stack<int>();
            var index = num.Length - 1;
            int carry = 0;

            while (k > 0)
            {
                var y = k % 10;
                k /= 10;

                var sum = (index >= 0 ? num[index] : 0) + y + carry;
                var toAdd = sum % 10;
                carry = sum / 10;
                result.Push(toAdd);

                index--;
            }

            while (index >= 0)
            {
                var sum = carry + num[index];
                var toAdd = sum % 10;
                carry = sum / 10;
                result.Push(toAdd);
                index--;
            }

            if (carry > 0)
            {
                result.Push(carry);
            }

            return new List<int>(result);
        }
    }
}
