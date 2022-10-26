using NUnit.Framework;

namespace Amazon.RA1
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
            var weights = new List<int>() { 2, 4, 3, 1, 6 };

            m.getMinMoves(weights);
        }
    }
}