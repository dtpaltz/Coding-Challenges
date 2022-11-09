using NUnit.Framework;

namespace Lula.C01_Is_Palindrome_Recursive
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
            var result = m.IsPalindrome(null);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void Test2()
        {
            Module m = new Module();
            var result = m.IsPalindrome("");

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void Test3()
        {
            Module m = new Module();
            var result = m.IsPalindrome("abc");

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void Test4()
        {
            Module m = new Module();
            var result = m.IsPalindrome("aabaa");

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Test5()
        {
            Module m = new Module();
            var result = m.IsPalindrome("abbbba");

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Test6()
        {
            Module m = new Module();
            var result = m.IsPalindrome("a");

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Test7()
        {
            Module m = new Module();
            var result = m.IsPalindrome("aaa");

            Assert.That(result, Is.EqualTo(true));
        }

    }
}