namespace Amazon.A003_Longest_Substring_Without_Repeating_Characters
{
    internal class Module
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;

            for (int startIdx = 0; startIdx < s.Length; startIdx++)
            {
                var charCache = new HashSet<char>();

                for (int i = startIdx; i < s.Length; i++)
                {
                    char nextCahr = s[i];

                    if (charCache.Contains(nextCahr))
                    {
                        break;
                    }

                    charCache.Add(nextCahr);
                    result = Math.Max(result, charCache.Count);
                }
            }

            return result;
        }
    }
}
