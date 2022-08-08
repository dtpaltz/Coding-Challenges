using System.Diagnostics;

namespace Challenges.C0012_CanBeIncreasing
{
    internal class Module
    {
        public bool CanBeIncreasing(int[] nums)
        {
            int numCount = nums.Length;

            if (numCount < 2)
            {
                return false;
            }

            // Stores the count of numbers that
            // are needed to be removed
            int needToRemoveCount = 0;

            // Store the index of the element
            // that needs to be removed
            int indexToRemove = -1;

            for (int i = 1; i < numCount; i++)
            {
                if (nums[i - 1] >= nums[i])
                {
                    needToRemoveCount++;
                    indexToRemove = i;
                }
            }

            // If count is greater than one
            if (needToRemoveCount > 1)
                return false;

            // If no element is removed
            if (needToRemoveCount == 0)
                return true;

            // If only the last OR the first element is removed
            if (indexToRemove == numCount - 1 || indexToRemove == 1)
                return true;

            // If a[index] is removed
            if (nums[indexToRemove - 1] < nums[indexToRemove + 1])
                return true;

            // If a[index - 1] is removed
            if (nums[indexToRemove - 2] < nums[indexToRemove])
                return true;

            return false;
        }
    }
}
