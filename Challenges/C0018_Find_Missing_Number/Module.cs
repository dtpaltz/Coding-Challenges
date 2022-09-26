using System.Diagnostics;

namespace Challenges.C0018_Find_Missing_Number
{
    internal class Module
    {
        public int FindMissing(int[] arr)
        {
            int eleSum = arr.Sum();
            int expSum = Enumerable.Range(1, arr.Length + 1).Sum();

            return expSum - eleSum;
        }
    }
}
