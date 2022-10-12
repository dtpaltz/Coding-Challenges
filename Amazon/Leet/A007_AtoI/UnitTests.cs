using NUnit.Framework;

namespace Amazon.A007_AtoI
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
            var arg1 = "42";

            Assert.That(m.MyAtoi(arg1), Is.EqualTo(42));
        }

        [Test]
        public void Test2()
        {
            var m = new Module();
            var arg1 = "   -42";

            Assert.That(m.MyAtoi(arg1), Is.EqualTo(-42));
        }

        [Test]
        public void Test3()
        {
            var m = new Module();
            var arg1 = "4193 with words";

            Assert.That(m.MyAtoi(arg1), Is.EqualTo(4193));
        }

        [Test]
        public void Test4()
        {
            var m = new Module();
            var arg1 = "    -91283472332 text";

            Assert.That(m.MyAtoi(arg1), Is.EqualTo(int.MinValue));
        }

        [Test]
        public void Test5()
        {
            var m = new Module();
            var arg1 = "    91283472332 text";

            Assert.That(m.MyAtoi(arg1), Is.EqualTo(int.MaxValue));
        }

        [Test]
        public void Test6()
        {
            var m = new Module();
            var arg1 = "words and 987";

            Assert.That(m.MyAtoi(arg1), Is.EqualTo(0));
        }


        
    }
}