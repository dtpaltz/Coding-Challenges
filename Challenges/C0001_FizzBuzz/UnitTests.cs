using NUnit.Framework;

namespace Challenges.C0001_FizzBuzz
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
            m.FizzBuzz(50);
        }
    }
}