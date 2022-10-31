using NUnit.Framework;

namespace Challenges.C1346_Check_N_and_Double_Exist
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

            var arg = new int[] { 10, 2, 5, 3 };
            var exp = true;

            Assert.That(exp, Is.EqualTo(m.CheckIfExist(arg)));
        }

        [Test]
        public void Test2()
        {
            var m = new Module();

            var arg = new int[] { 3, 1, 7, 11 };
            var exp = false;

            Assert.That(exp, Is.EqualTo(m.CheckIfExist(arg)));
        }

        [Test]
        public void Test3()
        {
            var m = new Module();

            var arg = new int[] { 0 };
            var exp = false;

            Assert.That(exp, Is.EqualTo(m.CheckIfExist(arg)));
        }

        [Test]
        public void Test4()
        {
            var m = new Module();

            var arg = new int[] { -2, 0, 10, -19, 4, 6, -8 };
            var exp = false;

            Assert.That(exp, Is.EqualTo(m.CheckIfExist(arg)));
        }

        [Test]
        public void Test5()
        {
            var m = new Module();

            var arg = new int[] { 0, 0 };
            var exp = true;

            Assert.That(exp, Is.EqualTo(m.CheckIfExist(arg)));
        }
    }
}