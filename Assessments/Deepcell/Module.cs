namespace Assessments.Deepcell
{
    /// <summary>
    /// DNA is composed of A, C, T, and G. Given the two sequences primary and secondary.
    /// 
    /// Determine:
    /// 1) Is primary a repeatable subsequence of secondary, if not return the inverse of secondary
    /// 2) The length of the shortest common subsequence of the two strings, and return this
    /// </summary>
    internal class Module
    {
        public int FindSmallestCommonDnaSubsequenceLength(string primary, string secondary)
        {
            if (IsRepeatedSubsequence(primary, secondary))
            {
                return ShortestCommonSubsequenceLength(primary,secondary);
            }

            return secondary.Length * -1;
        }

        public bool IsRepeatedSubsequence(string x, string y)
        {
            string repeatedSequence = x;

            while (repeatedSequence.Length < y.Length)
            {
                if (repeatedSequence.Length < (y.Length / 2))
                {
                    repeatedSequence += repeatedSequence;
                }
                else
                {
                    repeatedSequence += x;
                }
            }

            return repeatedSequence.Equals(y);
        }

        private int ShortestCommonSubsequenceLength(string x, string y)
        {
            int result = -1;

            for (int i = 1; i <= x.Length; i++)
            {
                if (y.Length % i == 0)
                {
                    string s = x.Substring(0, i);

                    if (IsRepeatedSubsequence(s, x))
                    {
                        result = s.Length;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
