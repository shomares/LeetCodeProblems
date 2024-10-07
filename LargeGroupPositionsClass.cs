using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LargeGroupPositionsClass
    {

        public IList<IList<int>> LargeGroupPositions(string s)
        {
            var result = new List<IList<int>>();

            var index = 0;
            var indexAnt = 0;
            var countItems = 0;
            char? ant = null;

            while (index < s.Length)
            {
                var c = s[index];

                if (c != ant)
                {
                    if (countItems >= 3)
                    {
                        result.Add(new List<int>()
                        {
                            indexAnt,
                            index -1
                        });
                    }

                    indexAnt = index;
                    ant = c;
                    countItems = 1;
                }
                else if (index == s.Length - 1 && countItems >= 2)
                {

                    result.Add(new List<int>()
                        {
                            indexAnt,
                            index
                        });
                }
                else
                {
                    countItems++;
                }


                index++;
            }


            return result;
        }
    }
}
