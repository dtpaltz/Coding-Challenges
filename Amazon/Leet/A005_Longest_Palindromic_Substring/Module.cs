namespace Amazon.A005_Longest_Palindromic_Substring
{
    internal class Module
    {
        public string LongestPalindrome(string s)
        {
            for (int strLength = s.Length; strLength > 0; strLength--)
            {
                for (int startIdx = 0; (startIdx + strLength) <= s.Length; startIdx++)
                {
                    var testStr = s.Substring(startIdx, strLength);

                    if (IsPalindrome(testStr))
                    {
                        return testStr;
                    }
                }
            }

            return null;
        }

        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char a = value[min];
                char b = value[max];

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }

                min++;
                max--;
            }
        }
    }
}
