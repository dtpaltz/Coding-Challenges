using NUnit.Framework;

namespace Challenges.C0018_Find_Missing_Number
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

            int[] arr = new int[] { 3, 7, 1, 2, 8, 4, 5 };

            Assert.That(m.FindMissing(arr), Is.EqualTo(6));
        }

        

    }
}