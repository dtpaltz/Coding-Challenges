using NUnit.Framework;

namespace Amazon.A001_TwoSum
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
            Module m = new Module();

            m.TwoSum(new int[] { 3, 2, 4 }, 6);
        }
    }
}