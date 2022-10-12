namespace Amazon.A003_Longest_Substring_Without_Repeating_Characters
{
    internal class Module
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;

            var charCache = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char nextCahr = s[i];

                if (charCache.Contains(nextCahr))
                {
                    result = Math.Max(result, charCache.Count);
                    charCache = new HashSet<char>();
                    continue;
                }

                charCache.Add(nextCahr);
            }

            return result;
        }
    }
}
