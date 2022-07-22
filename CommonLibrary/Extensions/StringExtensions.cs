namespace CommonLibrary.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Determine if given two strings are anagrams of each other or not. An anagram of a string is another string that contains the same characters, but the order of characters can be different.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>Return true if given two strings are anagrams of each other, otherwise false.</returns>
        public static bool AreAnagrams(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2) || s1.Length != s2.Length)
            {
                return false;
            }

            char[] a1 = s1.ToLower().ToCharArray();
            char[] a2 = s2.ToLower().ToCharArray();

            Array.Sort(a1);
            Array.Sort(a2);

            string res1 = new string(a1);
            string res2 = new string(a2);

            return res1 == res2;
        }
    }
}