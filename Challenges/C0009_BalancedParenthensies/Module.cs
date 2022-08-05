using System.Diagnostics;

namespace Challenges.C0009_BalancedParenthensies
{
    internal class Module
    {
        public static bool balancedParenthensies(String s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '[' || c == '(' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != '[')
                    {
                        return false;
                    }
                }
                else if (c == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        return false;
                    }
                }
                else if (c == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != '{')
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
