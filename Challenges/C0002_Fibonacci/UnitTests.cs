using NUnit.Framework;

namespace Challenges.C0002_Fibonacci
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
            var result = m.Fib(50);
        }
    }
}