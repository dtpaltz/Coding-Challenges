using NUnit.Framework;

namespace Amazon.OA011_Simple_Cipher
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

            Assert.That(m.DecodeCipher("VTAOG", 2), Is.EqualTo("TRYME"));
        }
    }
}