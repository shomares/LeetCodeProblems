using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FreqAlphabetsClass
    {
        public string FreqAlphabets(string s)
        {
            var index = s.Length - 1;
            var strBuilder = new StringBuilder();
            var bag = new Stack<char>();

            while (index >= 0)
            {
                var aux = s[index];
                var str = string.Empty;

                if (aux == '#')
                {
                    var top = index - 2;

                    while (top < index)
                    {
                        str += s[top];
                        top++;
                    }


                    index -= 3;
                }
                else
                {
                    str += aux;
                    index--;
                }

                var intStr = int.Parse(str);

                var charToAppend = (char)(intStr + 0x60);
                bag.Push(charToAppend);
            }

            while (bag.Count > 0)
            {
                strBuilder.Append(bag.Pop());
            }

            return strBuilder.ToString();
        }
    }
}
