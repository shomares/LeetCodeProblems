namespace LeetCode
{
    public class ValidParantheses
    {
        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();
            int index = 0;

            while (index < s.Length)
            {
                var charValue = s[index];

                if (charValue == '{' || charValue == '(' || charValue == '[')
                {
                    stack.Push(charValue);
                }
                else
                {
                    if (stack.TryPeek(out var value))
                    {
                        if (
                          (value == '{' && charValue == '}') ||
                          (value == '(' && charValue == ')') ||
                          (value == '[' && charValue == ']')
                      )
                        {
                            stack.Pop();
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
                }


                index++;
            }


            return stack.Count == 0 && s.Length > 1;
        }
    }
}
