namespace Amazon.A001_TwoSum
{
    internal class Module
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            var deltaCache = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (deltaCache.ContainsKey(nums[i]))
                {
                    result = new int[] { deltaCache[nums[i]], i };
                    break;
                }

                deltaCache.TryAdd(target - nums[i], i);
            }

            return result;
        }
    }
}
