using NUnit.Framework;

namespace Lula.C02_First_Unique_Char
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
            var result = m.FirstUnichiqueChar(null);

            Assert.That(result, Is.EqualTo('\0'));
        }

        [Test]
        public void Test2()
        {
            Module m = new Module();
            var result = m.FirstUnichiqueChar("");

            Assert.That(result, Is.EqualTo('\0'));
        }

        [Test]
        public void Test3()
        {
            Module m = new Module();
            var result = m.FirstUnichiqueChar("aaaaaabbbbccccc");

            Assert.That(result, Is.EqualTo('\0'));
        }

        [Test]
        public void Test4()
        {
            Module m = new Module();
            var result = m.FirstUnichiqueChar("aaaaaabcde");

            Assert.That(result, Is.EqualTo('b'));
        }

        [Test]
        public void Test5()
        {
            Module m = new Module();
            var result = m.FirstUnichiqueChar("banana");

            Assert.That(result, Is.EqualTo('b'));
        }
    }
}