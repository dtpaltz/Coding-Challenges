using System.Diagnostics;

namespace Challenges.C0015_Third_Max
{
    internal class Module
    {
        public int ThirdMax(int[] nums)
        {
            if (nums.Length < 3)
            {
                return nums.Max();
            }

            // Find first largest element
            int first = -999;
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                if (n > first)
                {
                    first = n;
                }
            }

            // Find second largest element
            int second = -first;
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                if (n < first && n > second)
                {
                    second = n;
                }
            }

            // Find third largest element
            int third = -second;
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                if (n < second && n > third)
                {
                    third = n;
                }
            }

            return third;
        }
    }
}
