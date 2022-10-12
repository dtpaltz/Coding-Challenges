namespace Amazon.A008_3Sum
{
    internal class Module
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<List<int>> ans = new List<List<int>>();
            Array.Sort(nums);
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                int p = i + 1, q = n - 1;
                while (p < q)
                {
                    if (nums[p] + nums[q] == -nums[i])
                    {
                        ans.Add(new List<int>() { nums[i], nums[p], nums[q] });

                        while (p + 1 < q && nums[p + 1] == nums[p]) p++;
                        while (q - 1 > p && nums[q - 1] == nums[q]) q--;

                        p++; q--;
                    }
                    else if (nums[p] + nums[q] < -nums[i]) p++;
                    else q--;
                }

                while (i + 1 < n && nums[i + 1] == nums[i]) i++;
            }

            return (IList<IList<int>>)ans;
        }
    }
}
