using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindDifferenceClass
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var result = new List<IList<int>>();
            var m1 = new HashSet<int>(nums1);
            var m2 = new HashSet<int>(nums2);

            var r1 = new HashSet<int>();

            foreach (var i in nums1)
            {
                if (!m2.Contains(i))
                {
                    r1.Add(i);
                }
            }

            var r2 = new HashSet<int>();
            foreach(var i in nums2)
            {
                if(!m1.Contains(i))
                {
                    r2.Add(i);
                }
            }


            result.Add([..r1]);
            result.Add([..r2]);


            return result;
        }
    }
}
