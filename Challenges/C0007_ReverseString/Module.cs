using System.Diagnostics;

namespace Challenges.C0007_ReverseString
{
    internal class Module
    {
        /// <summary>
        /// Reverse a given string using a stack
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Reverse(string str)
        {
            Stack<char> charStack = new Stack<char>();

            foreach (var c in str)
            {
                charStack.Push(c);
            }

            string result = "";

            while (charStack.Count > 0)
            {
                result += charStack.Pop();
            }

            return result;
        }
    }
}
