using NUnit.Framework;

namespace Amazon.A005_Longest_Palindromic_Substring
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
            var arr1 = "babad";

            Assert.That(m.LongestPalindrome(arr1), Is.EqualTo("bab"));
        }

        [Test]
        public void Test2()
        {
            Module m = new Module();
            var arr1 = "cbbd";

            Assert.That(m.LongestPalindrome(arr1), Is.EqualTo("bb"));
        }

        [Test]
        public void Test3()
        {
            Module m = new Module();
            var arr1 = "babad";

            Assert.That(m.LongestPalindrome(arr1), Is.EqualTo("bab"));
        }
    }
}