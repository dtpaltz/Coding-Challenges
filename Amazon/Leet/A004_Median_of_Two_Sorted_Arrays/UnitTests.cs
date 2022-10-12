using NUnit.Framework;

namespace Amazon.A004_Median_of_Two_Sorted_Arrays
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
            var arr1 = new int[] { 1, 3 };
            var arr2 = new int[] { 2 };

            Assert.That(m.FindMedianSortedArrays(arr1, arr2), Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            Module m = new Module();
            var arr1 = new int[] { 1, 2 };
            var arr2 = new int[] { 3, 4 };

            Assert.That(m.FindMedianSortedArrays(arr1, arr2), Is.EqualTo(2.50000));
        }

        [Test]
        public void Test3()
        {
            Module m = new Module();
            var arr1 = new int[] { 1, 1 };
            var arr2 = new int[] { 1, 2 };

            Assert.That(m.FindMedianSortedArrays(arr1, arr2), Is.EqualTo(1));
        }
    }
}