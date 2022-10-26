using NUnit.Framework;

namespace Challenges.C0066_Plus_One
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

            int[] arr = new int[] { 1, 2, 3 };
            int[] exp = new int[] { 1, 2, 4 };

            Assert.IsTrue(Enumerable.SequenceEqual(m.PlusOne(arr), exp));
        }

        [Test]
        public void Test2()
        {
            var m = new Module();

            int[] arr = new int[] { 4, 3, 2, 1 };
            int[] exp = new int[] { 4, 3, 2, 2 };

            Assert.IsTrue(Enumerable.SequenceEqual(m.PlusOne(arr), exp));
        }

        [Test]
        public void Test3()
        {
            var m = new Module();

            int[] arr = new int[] { 9 };
            int[] exp = new int[] { 1, 0 };

            Assert.IsTrue(Enumerable.SequenceEqual(m.PlusOne(arr), exp));
        }

        [Test]
        public void Test4()
        {
            var m = new Module();

            int[] arr = new int[] { 9, 9, 9 };
            int[] exp = new int[] { 1, 0, 0, 0 };

            Assert.IsTrue(Enumerable.SequenceEqual(m.PlusOne(arr), exp));
        }



    }
}