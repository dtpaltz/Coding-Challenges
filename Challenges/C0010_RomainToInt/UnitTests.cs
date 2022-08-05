using CommonLibrary.Grid;
using NUnit.Framework;

namespace Challenges.C0010_RomainToInt
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

            Assert.That(m.RomanToInt("IX"), Is.EqualTo(9));
        }
    }
}