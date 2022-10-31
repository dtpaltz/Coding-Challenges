using CommonLibrary.LinkedList;
using NUnit.Framework;

namespace Challenges.C0058_Length_of_Last_Word
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

            var arg = "Hello World   ";
            var exp = 5;

            Assert.That(m.LengthOfLastWord(arg), Is.EqualTo(exp));
        }

        [Test]
        public void Test2()
        {
            var m = new Module();

            var arg = "   fly me   to   the moon  ";
            var exp = 4;

            Assert.That(m.LengthOfLastWord(arg), Is.EqualTo(exp));
        }

    }
}