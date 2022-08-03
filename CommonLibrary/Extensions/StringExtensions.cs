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

        public static List<int> AllIndexesOf(this string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");

            List<int> indexes = new List<int>();

            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);

                if (index == -1)
                    return indexes;

                indexes.Add(index);
            }
        }

        public static List<string> AllSubstringsOfLength(this string str, int substringLength)
        {
            var result = new List<string>();

            if (!string.IsNullOrEmpty(str) && substringLength > 0 && substringLength < str.Length)
            {
                for (int i = 0; i < (str.Length - substringLength + 1); i++)
                {
                    result.Add(str.Substring(i, substringLength));
                }
            }

            return result;
        }

        /// <summary>
        /// Returns the number of steps required to transform the source string
        /// into the target string.
        /// </summary>
        static int ComputeLevenshteinDistance(string source, string target)
        {
            if ((source == null) || (target == null)) return 0;
            if ((source.Length == 0) || (target.Length == 0)) return 0;
            if (source == target) return source.Length;

            int sourceWordCount = source.Length;
            int targetWordCount = target.Length;

            // Step 1
            if (sourceWordCount == 0)
                return targetWordCount;

            if (targetWordCount == 0)
                return sourceWordCount;

            int[,] distance = new int[sourceWordCount + 1, targetWordCount + 1];

            // Step 2
            for (int i = 0; i <= sourceWordCount; distance[i, 0] = i++) ;
            for (int j = 0; j <= targetWordCount; distance[0, j] = j++) ;

            for (int i = 1; i <= sourceWordCount; i++)
            {
                for (int j = 1; j <= targetWordCount; j++)
                {
                    // Step 3
                    int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;

                    // Step 4
                    distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + cost);
                }
            }

            return distance[sourceWordCount, targetWordCount];
        }






        /// <summary>
        /// Calculate percentage similarity of two strings
        /// <param name="source">Source String to Compare with</param>
        /// <param name="target">Targeted String to Compare</param>
        /// <returns>Return Similarity between two strings from 0 to 1.0</returns>
        /// </summary>
        static double CalculateSimilarity(string source, string target)
        {
            if ((source == null) || (target == null)) return 0.0;
            if ((source.Length == 0) || (target.Length == 0)) return 0.0;
            if (source == target) return 1.0;

            int stepsToSame = ComputeLevenshteinDistance(source, target);
            return (1.0 - ((double)stepsToSame / (double)Math.Max(source.Length, target.Length)));
        }

    }
}