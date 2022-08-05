using System.Diagnostics;

namespace Challenges.C0011_StrStr
{
    internal class Module
    {
        public int StrStr(string haystack, string needle)
        {
            int result = 0;

            if (!string.IsNullOrEmpty(needle))
            {
                result = haystack.IndexOf(needle);
            }

            return result;
        }
    }
}
