using NUnit.Framework;

namespace Challenges.C0004_SherlockAndAnagrams
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
            int result = m.SherlockAndAnagrams("abba");

            Assert.That(4, Is.EqualTo(result));
        }

        [Test]
        public void Test2()
        {
            Module m = new Module();
            int result = m.SherlockAndAnagrams("abcd");

            Assert.That(0, Is.EqualTo(result));
        }

        [Test]
        public void Test3()
        {
            Module m = new Module();
            int result = m.SherlockAndAnagrams("ifailuhkqq");

            Assert.That(3, Is.EqualTo(result));
        }

        [Test]
        public void Test4()
        {
            Module m = new Module();
            int result = m.SherlockAndAnagrams("mom");

            Assert.That(2, Is.EqualTo(result));
        }

        [Test]
        public void Test5()
        {
            Module m = new Module();
            int result = m.SherlockAndAnagrams("kkkk");

            Assert.That(10, Is.EqualTo(result));
        }

        [Test]
        public void Test6()
        {
            Module m = new Module();
            int result = m.SherlockAndAnagrams("cdcd");

            Assert.That(5, Is.EqualTo(result));
        }

        [Test]
        public void Test7()
        {
            Module m = new Module();
            int result = m.SherlockAndAnagrams("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq");

            Assert.That(45760, Is.EqualTo(result));
        }
    }
}