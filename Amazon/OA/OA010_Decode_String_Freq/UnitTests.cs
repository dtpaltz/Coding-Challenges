using NUnit.Framework;

namespace Amazon.OA010_Decode_String_Freq
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

            Assert.That(m.DecodeCharFreq("23#(2)24#25#26#23#(3)"), Is.EqualTo("wwxyzwww"));
        }

        [Test]
        public void Test2()
        {
            Module m = new Module();

            Assert.That(m.DecodeCharFreq("2110#(2)"), Is.EqualTo("bajj"));
        }

        [Test]
        public void Test3()
        {
            Module m = new Module();

            Assert.That(m.DecodeCharFreq("1(2)23(3)"), Is.EqualTo("aabccc"));
        }

        [Test]
        public void Test4()
        {
            Module m = new Module();

            Assert.That(m.DecodeCharFreq("1226#24#"), Is.EqualTo("abzx"));
        }
    }
}