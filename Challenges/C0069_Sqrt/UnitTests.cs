using NUnit.Framework;

namespace Challenges.C0069_Sqrt
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

            var arg = 8;
            var exp = 2;

            Assert.That(m.MySqrt(arg), Is.EqualTo(exp));
        }
    }
}