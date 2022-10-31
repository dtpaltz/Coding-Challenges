using NUnit.Framework;

namespace Challenges.C1805_Number_of_Different_Integers_in_String
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

            var arg = "a123bc34d8ef34";
            var exp = 3;

            Assert.That(exp, Is.EqualTo(m.NumDifferentIntegers(arg)));
        }

        [Test]
        public void Test2()
        {
            var m = new Module();

            var arg = "leet1234code234";
            var exp = 2;

            Assert.That(exp, Is.EqualTo(m.NumDifferentIntegers(arg)));
        }

        [Test]
        public void Test3()
        {
            var m = new Module();

            var arg = "a1b01c001";
            var exp = 1;

            Assert.That(exp, Is.EqualTo(m.NumDifferentIntegers(arg)));
        }
    }
}