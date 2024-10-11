using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NumUniqueEmailsClass
    {
        public int NumUniqueEmails(string[] emails)
        {
            var cache = new HashSet<string>();

            foreach (var email in emails)
            {
                var separate = email.Split('@');
                if (separate.Length < 2)
                {
                    continue;
                }

                var name = separate[0];

                var index = 0;
                var nameS = new StringBuilder();

                while (index < name.Length)
                {
                    var charV = name[index];

                    if (charV == '+')
                    {
                        break;
                    }

                    if (charV == '.')
                    {
                        index++;
                        continue;
                    }

                    nameS.Append(charV);

                    index++;
                }

                cache.Add($"{nameS}@{separate[1]}");

            }


            return cache.Count;

        }
    }
}
