using CommonLibrary.Extensions;

namespace Challenges.C0004_SherlockAndAnagrams
{
    internal class Module
    {
        public int SherlockAndAnagrams(string s)
        {
            int result = 0;

            for (int substringLength = 1; substringLength < s.Length; substringLength++)
            {
                var theseSubstrings = s.AllSubstringsOfLength(substringLength);

                for (int i = 0; i < theseSubstrings.Count - 1; i++)
                {
                    for (int j = i + 1; j < theseSubstrings.Count; j++)
                    {
                        if (StringExtensions.AreAnagrams(theseSubstrings[i], theseSubstrings[j]))
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
