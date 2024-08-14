using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Roman
    {
        public static int RomanToInt(string s)
        {
            var index = s.Length - 1;

            var dictionary = new Dictionary<char, int>() {
                {
                    'I', 1
                },
                {
                    'V', 5
                },
                {
                    'X', 10
                },
                {
                    'L', 50
                },
                {
                    'C', 100
                },
                {
                    'D', 500
                },
                {
                    'M', 1000
                }

            };

            int valueAnterior = 0;
            int result = 0;

            while (index >= 0)
            {
                var toEvaluate = s[index];
                var valueActual = dictionary[toEvaluate];

                if (valueAnterior > valueActual)
                {
                    result -= valueActual;
                }
                else
                {
                    result += valueActual;
                }

                valueAnterior = valueActual;
                index--;
            }

            return result;
        }
    }
}
