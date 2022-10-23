using NUnit.Framework;

namespace Amazon.OA007_Shipment_Imbalances
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
            var nums = new int[] { 1, 2, 3 };

            m.ShipmentImbalance(nums);
        }
    }
}