using CommonLibrary.Grid;
using NUnit.Framework;

namespace Challenges.C0011_StrStr
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

            Assert.That(m.StrStr("hello", "ll"), Is.EqualTo(2));
        }
    }
}