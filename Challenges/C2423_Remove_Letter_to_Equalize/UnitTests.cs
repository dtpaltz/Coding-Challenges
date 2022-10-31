using NUnit.Framework;

namespace Challenges.C2423_Remove_Letter_to_Equalize
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
            var m = new Module();

            var arg = "abcc";
            var exp = true;

            Assert.That(m.EqualFrequency(arg), Is.EqualTo(exp));
        }

        [Test]
        public void Test2()
        {
            var m = new Module();

            var arg = "aazz";
            var exp = false;

            Assert.That(m.EqualFrequency(arg), Is.EqualTo(exp));
        }

        [Test]
        public void Test3()
        {
            var m = new Module();

            var arg = "aabbbcccccc";
            var exp = false;

            Assert.That(m.EqualFrequency(arg), Is.EqualTo(exp));
        }

        [Test]
        public void Test4()
        {
            var m = new Module();

            var arg = "";
            var exp = false;

            Assert.That(m.EqualFrequency(arg), Is.EqualTo(exp));
        }

        [Test]
        public void Test5()
        {
            var m = new Module();

            string arg = null;
            var exp = false;

            Assert.That(m.EqualFrequency(arg), Is.EqualTo(exp));
        }

        [Test]
        public void Test6()
        {
            var m = new Module();

            var arg = "abccddee";
            var exp = false;

            Assert.That(m.EqualFrequency(arg), Is.EqualTo(exp));
        }

        [Test]
        public void Test7()
        {
            var m = new Module();

            var arg = "bac";
            var exp = true;

            Assert.That(m.EqualFrequency(arg), Is.EqualTo(exp));
        }

        [Test]
        public void Test8()
        {
            var m = new Module();

            var arg = "abbccddeeff";
            var exp = true;

            Assert.That(m.EqualFrequency(arg), Is.EqualTo(exp));
        }
    }
}