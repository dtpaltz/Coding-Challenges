using NUnit.Framework;

namespace Challenges.C0013_BuddyStrings
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
            string s = "";
            string goal = "";

            Assert.That(m.BuddyStrings(s, goal), Is.EqualTo(false));
        }

        [Test]
        public void Test2()
        {
            var m = new Module();
            var s = "a";
            var goal = "a";

            Assert.That(m.BuddyStrings(s, goal), Is.EqualTo(false));
        }

        [Test]
        public void Test3()
        {
            var m = new Module();
            var s = "aa";
            var goal = "aa";

            Assert.That(m.BuddyStrings(s, goal), Is.EqualTo(true));
        }

        [Test]
        public void Test4()
        {
            var m = new Module();
            var s = "ab";
            var goal = "ab";

            Assert.That(m.BuddyStrings(s, goal), Is.EqualTo(false));
        }

        [Test]
        public void Test5()
        {
            var m = new Module();
            var s = "ab";
            var goal = "ba";

            Assert.That(m.BuddyStrings(s, goal), Is.EqualTo(true));
        }

        [Test]
        public void Test6()
        {
            var m = new Module();
            var s = "hello";
            var goal = "oellh";

            Assert.That(m.BuddyStrings(s, goal), Is.EqualTo(true));
        }
    }
}