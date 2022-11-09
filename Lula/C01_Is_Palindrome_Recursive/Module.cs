using System.Diagnostics;

namespace Lula.C01_Is_Palindrome_Recursive
{
    internal class Module
    {
        public bool IsPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            return OffsetsMatch(str, 0);
        }

        private bool OffsetsMatch(string str, int idxOffset)
        {
            if (idxOffset > idxOffset / 2)
            {
                return true;
            }

            var charA = str[0 + idxOffset];
            var charB = str[str.Length - 1 - idxOffset];

            if (charA == charB)
            {
                return OffsetsMatch(str, idxOffset + 1);
            }

            return false;
        }
    }
}
