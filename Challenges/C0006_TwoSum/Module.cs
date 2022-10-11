namespace Challenges.C0006_TwoSum
{
    internal class Module
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> deltas = new Dictionary<int, int>(); //key == delta, value == index
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (deltas.ContainsKey(nums[i]))
                {
                    result = new int[] { deltas[nums[i]], i };
                    break;
                }

                deltas.TryAdd(target - nums[i], i);
            }

            return result;
        }
    }
}
