using CommonLibrary.LinkedList;
using NUnit.Framework;

namespace Amazon.A003_Longest_Substring_Without_Repeating_Characters
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Module m = new Module();
            string input = "abcabcbb";

            m.LengthOfLongestSubstring(input);
        }
    }
}