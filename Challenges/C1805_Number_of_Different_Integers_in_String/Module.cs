using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Challenges.C1805_Number_of_Different_Integers_in_String
{
    internal class Module
    {
        public int NumDifferentIntegers(string word)
        {
            Regex rgx = new Regex("[a-z]");
            var numsInStr = rgx.Replace(word, " ").Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(x => x.TrimStart('0')).ToArray();
            var distinctNumsInStr = new HashSet<string>(numsInStr);

            return distinctNumsInStr.Count;
        }
    }
}
