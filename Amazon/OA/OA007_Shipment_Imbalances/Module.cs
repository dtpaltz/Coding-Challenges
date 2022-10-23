namespace Amazon.OA007_Shipment_Imbalances
{
    internal class Module
    {
        public long ShipmentImbalance(int[] nums)
        {
            long result = 0;

            for (int subLen = 1; subLen <= nums.Length; subLen++)
            {
                for (int idx = 0; idx + subLen <= nums.Length; idx++)
                {
                    var suba = nums.Skip(idx).Take(subLen).ToArray();
                    result += suba.Max() - suba.Min();
                }
            }

            return result;
        }
    }
}
