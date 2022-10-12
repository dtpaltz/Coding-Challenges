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
        public void Test11()
        {
            Module m = new Module();
            string input = "abcabcbb";

            Assert.That(m.LengthOfLongestSubstring(input), Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            Module m = new Module();
            string input = "pwwkew";

            Assert.That(m.LengthOfLongestSubstring(input), Is.EqualTo(3));
        }

        [Test]
        public void Test3()
        {
            Module m = new Module();
            string input = "aab";

            Assert.That(m.LengthOfLongestSubstring(input), Is.EqualTo(2));
        }

        [Test]
        public void Test4()
        {
            Module m = new Module();
            string input = "dvdf";

            Assert.That(m.LengthOfLongestSubstring(input), Is.EqualTo(3));
        }
    }
}