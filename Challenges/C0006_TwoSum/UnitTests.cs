using CommonLibrary.Grid;
using NUnit.Framework;

namespace Challenges.C0006_TwoSum
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

            m.TwoSum(new int[] { 3, 2, 4 }, 6);
        }
    }
}