using CommonLibrary.Grid;
using NUnit.Framework;

namespace Challenges.C0012_CanBeIncreasing
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

            Assert.That(m.CanBeIncreasing(new int[] { 1, 2, 10, 5, 7 }), Is.EqualTo(true));
        }
    }
}