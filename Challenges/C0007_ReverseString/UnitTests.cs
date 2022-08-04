using CommonLibrary.Grid;
using NUnit.Framework;

namespace Challenges.C0007_ReverseString
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

            m.Reverse("word");
        }
    }
}