using NUnit.Framework;

namespace Challenges.C0015_Third_Max
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
            var arr = new int[] { 1, 2 };

            Assert.That(m.ThirdMax(arr), Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var m = new Module();
            var arr = new int[] { 2, 2, 3, 1 };

            Assert.That(m.ThirdMax(arr), Is.EqualTo(1));
        }

        [Test]
        public void Test3()
        {
            var m = new Module();
            var arr = new int[] { 2, 3, 1 };

            Assert.That(m.ThirdMax(arr), Is.EqualTo(1));
        }
    }
}