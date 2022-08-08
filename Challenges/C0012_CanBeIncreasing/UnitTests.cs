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
            var arr = new int[] { };

            Assert.That(m.CanBeIncreasing(arr), Is.EqualTo(false));
        }

        [Test]
        public void Test2()
        {
            var m = new Module();
            var arr = new int[] { 3 };

            Assert.That(m.CanBeIncreasing(arr), Is.EqualTo(false));
        }

        [Test]
        public void Test3()
        {
            var m = new Module();
            var arr = new int[] { 1, 2, 3, 4, 5 };

            Assert.That(m.CanBeIncreasing(arr), Is.EqualTo(true));
        }

        [Test]
        public void Test4()
        {
            var m = new Module();
            var arr = new int[] { 5, 4, 3, 2, 1 };

            Assert.That(m.CanBeIncreasing(arr), Is.EqualTo(false));
        }

        [Test]
        public void Test5()
        {
            var m = new Module();
            var arr = new int[] { 1, 2, 5, 3, 4 };

            Assert.That(m.CanBeIncreasing(arr), Is.EqualTo(true));
        }

        [Test]
        public void Test6()
        {
            var m = new Module();
            var arr = new int[] { 1, 2, 4, 5, 3 };

            Assert.That(m.CanBeIncreasing(arr), Is.EqualTo(true));
        }

        [Test]
        public void Test7()
        {
            var m = new Module();
            var arr = new int[] { 5, 1, 2, 3, 4 };

            Assert.That(m.CanBeIncreasing(arr), Is.EqualTo(true));
        }

        [Test]
        public void Test8()
        {
            var m = new Module();
            var arr = new int[] { 2, 3, 4, 5, 1 };

            Assert.That(m.CanBeIncreasing(arr), Is.EqualTo(true));
        }

        [Test]
        public void Test9()
        {
            var m = new Module();
            var arr = new int[] { 4, 5, 1, 2, 3 };

            Assert.That(m.CanBeIncreasing(arr), Is.EqualTo(false));
        }

        [Test]
        public void Test10()
        {
            var m = new Module();
            var arr = new int[] { 3, 4, 5, 1, 2 };

            Assert.That(m.CanBeIncreasing(arr), Is.EqualTo(false));
        }
    }
}