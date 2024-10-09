using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Uncommonwords
    {

        public string[] UncommonFromSentences(string s1, string s2)
        {
            var dic = new Dictionary<string, int>();

            var words1 = s1.Split(' ');

            foreach (var word in words1)
            {
                if (dic.TryGetValue(word, out var occurences))
                {
                    dic[word] = ++occurences;
                }
                else
                {
                    dic.Add(word, 1); 
                }
            }

            var words2 = s2.Split(" ");
            foreach (var word in words2)
            {
                if (dic.TryGetValue(word, out var occurences))
                {
                    dic[word] = ++occurences;
                }
                else
                {
                    dic.Add(word, 1);
                }
            }

            var result = new List<string>();

            foreach(var entry in dic)
            {
                if(entry.Value == 1)
                {
                    result.Add(entry.Key);
                }

            }

            return [..result];
        }
    }
}
