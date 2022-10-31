using CommonLibrary.LinkedList;
using System.Diagnostics;

namespace Challenges.C0058_Length_of_Last_Word
{
    internal class Module
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int result = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                var currChar = s[i];
                if (currChar.CompareTo(' ') != 0)
                {
                    result++;
                }
                else if (result > 0)
                {
                    break;
                }
            }

            return result;
        }
    }
}
