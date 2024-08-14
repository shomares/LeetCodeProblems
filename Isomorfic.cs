
namespace LeetCode
{
    internal class Isomorfic
    {
        public static bool ValidateMap(char charS, char charT, IDictionary<char, char> map)
        {
            if (!map.TryGetValue(charS, out char value))
            {
                map.Add(charS, charT);
            }
            else
            {
                if (value != charT)
                {
                    return false;
                }
            }

            return true;
        }
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var mapA = new Dictionary<char, char>();
            var mapInverse = new Dictionary<char, char>();

            for (int i = 0; i < t.Length; i++)
            {
                var charS = s[i];
                var charT = t[i];

                var validate = ValidateMap(charS, charT, mapA) && ValidateMap(charT, charS, mapInverse);

                if (!validate)
                {
                    return false;
                }

            }

            return true;


        }
    }
}
