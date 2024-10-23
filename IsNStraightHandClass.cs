using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IsNStraightHandClass
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0)
            {
                return false;
            }


            var hashmap = new SortedDictionary<int, int>();

            foreach (int i in hand)
            {
                if (hashmap.TryGetValue(i, out int count))
                {
                    hashmap[i] = ++count;
                }
                else
                {
                    hashmap.Add(i, 1);
                }
            }

            var index = 0;
            var sizeG = 0;

            var keys = hashmap.Keys.ToArray();


            while (index < hashmap.Count)
            {
                var key = keys[index];

                if (hashmap.TryGetValue(key, out int count) && count > 0)
                {
                    if (index == 0 || sizeG == 0 || keys[index - 1] == key - 1)
                    {
                        hashmap[key] = --count;
                        sizeG++;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }

                if (sizeG == groupSize)
                {
                    sizeG = 0;

                    while (index >= 0 && hashmap[keys[index]] > 0)
                    {
                        index--;
                    }

                    if (index > 0 && hashmap[keys[index - 1]] > 0)
                    {
                        return false;
                    }
                }



                index++;
            }


            index--;
            while (index >= 0)
            {
                if (hashmap[keys[index]] > 0)
                {
                    return false;
                }

                index--;
            }



            return true;
        }
    }
}
