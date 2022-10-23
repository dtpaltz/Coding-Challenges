using NUnit.Framework;

namespace Amazon.OA009_Lowest_Price
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

            var products = new string[3][];
            products[0] = new string[] { "10", "d0", "d1" };
            products[1] = new string[] { "15", "EMPTY", "EMPTY" };
            products[2] = new string[] { "20", "d1", "EMPTY" };

            var discounts = new string[2][];
            discounts[0] = new string[] { "d0", "1", "27" };
            discounts[1] = new string[] { "d1", "2", "5" };

            m.LowestPrice(products, discounts);
        }
    }
}