using NUnit.Framework;

namespace Amazon.A008_3Sum
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
            var arg1 = new int[] { -1, 0, 1, 2, -1, -4 };

            var result = m.ThreeSum(arg1);
        }

        [Test]
        public void Test2()
        {
            var m = new Module();
            var arg1 = new int[] { 0, 1, 1 };

            var result = m.ThreeSum(arg1);
        }

        [Test]
        public void Test3()
        {
            var m = new Module();
            var arg1 = new int[] { 0, 0, 0 };

            var result = m.ThreeSum(arg1);
        }


        
    }
}