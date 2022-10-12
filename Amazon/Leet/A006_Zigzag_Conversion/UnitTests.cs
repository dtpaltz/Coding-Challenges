using NUnit.Framework;

namespace Amazon.A006_Zigzag_Conversion
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
            var arg1 = "PAYPALISHIRING";
            int arg2 = 3;

            Assert.That(m.Convert(arg1, arg2), Is.EqualTo("PAHNAPLSIIGYIR"));
        }

        [Test]
        public void Test2()
        {
            var m = new Module();
            var arg1 = "PAYPALISHIRING";
            int arg2 = 4;

            Assert.That(m.Convert(arg1, arg2), Is.EqualTo("PINALSIGYAHRPI"));
        }

        [Test]
        public void Test3()
        {
            var m = new Module();
            var arg1 = "A";
            int arg2 = 1;

            Assert.That(m.Convert(arg1, arg2), Is.EqualTo("A"));
        }
    }
}