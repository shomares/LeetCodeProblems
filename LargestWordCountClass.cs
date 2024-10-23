using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LargestWordCountClass
    {

        public string LargestWordCount(string[] messages, string[] senders)
        {
            if (messages.Length != senders.Length)
            {
                return string.Empty;
            }

            var dictionary = new Dictionary<string, int>();
            var index = 0;

            while (index < messages.Length)
            {
                var sender = senders[index];
                var message = messages[index];

                if (dictionary.TryGetValue(sender, out var count))
                {
                    dictionary[sender] = count + message.Split(' ').Length;
                }
                else
                {
                    dictionary.Add(sender, message.Split(' ').Length);
                }

                index++;
            }

            var maxLength = int.MinValue;
            var result = new List<string>();

            foreach (var entry in dictionary)
            {
                if (
                    maxLength == int.MinValue
                   )
                {
                    result.Add(entry.Key);
                    maxLength = entry.Value;
                }else if (entry.Value > maxLength)
                {
                    result.Clear();
                    result.Add(entry.Key);
                    maxLength = entry.Value;
                }else if (entry.Value == maxLength)
                {
                    result.Add(entry.Key);
                }

            }

            return result.OrderBy(it=>it, StringComparer.Ordinal).Last();

        }
    }
}
