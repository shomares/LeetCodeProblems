using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LeetCode
{
    internal class SortArrayByParityIIClass
    {
        public int[] ReorganizeArray(int[] nums)
        {
            var indexLeft = 0;
            var indexRight = nums.Length - 1;
            var isPair = true;

            while (indexLeft < indexRight)
            {
                // Mover indexLeft hacia la derecha
                while (indexLeft < nums.Length &&
                       ((isPair && nums[indexLeft] % 2 == 0) ||
                        (!isPair && nums[indexLeft] % 2 != 0)))
                {
                    indexLeft++;
                }

                // Mover indexRight hacia la izquierda
                while (indexRight >= 0 &&
                       ((isPair && nums[indexRight] % 2 != 0) ||
                        (!isPair && nums[indexRight] % 2 == 0)))
                {
                    indexRight--;
                }

                // Si ambos índices son válidos, realiza el intercambio
                if (indexLeft < indexRight)
                {
                    (nums[indexLeft], nums[indexRight]) = (nums[indexRight], nums[indexLeft]);
                }

                // Alterna el estado de isPair
                isPair = !isPair;
            }

            return nums;
        }

    }
}
