using NUnit.Framework;

namespace Challenges.C0003_MinimumBribes
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
            List<int> list = new List<int>() { 2, 1, 5, 3, 4 };
            Module m = new Module();
            m.minimumBribes(list);
        }

        [Test]
        public void Test2()
        {
            List<int> list = new List<int>() { 2, 5, 1, 3, 4 };
            Module m = new Module();
            m.minimumBribes(list);
        }

        [Test]
        public void Test3()
        {
            List<int> list = new List<int>() { 1, 2, 5, 3, 4, 7, 8, 6 };
            Module m = new Module();
            m.minimumBribes(list);
        }

        [Test]
        public void Test4()
        {
            List<int> list = new List<int>() { 5, 1, 2, 3, 7, 8, 6, 4 };
            Module m = new Module();
            m.minimumBribes(list); // expected 7
        }

        [Test]
        public void Test5()
        {
            List<int> list = new List<int>() { 1, 2, 5, 3, 7, 8, 6, 4 };
            Module m = new Module();
            m.minimumBribes(list); // expected 7
        }
    }
}