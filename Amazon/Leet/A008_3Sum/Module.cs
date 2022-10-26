namespace Amazon.A008_3Sum
{
    internal class Module
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            //this is where final result will live.
            var reslist = new List<IList<int>>();
            //sort the array so search is quicker
            Array.Sort(nums);
            var pre = 0; //keep track previous number
            //start from end of array
            for (var i = nums.Length - 1; i > 1; i--)
            {
                //if not at the start of loop and previous number equals to current number
                //no need to continue, the triplet (if there is one) will be the same
                if (i != nums.Length - 1 && nums[i] == pre)
                {
                    continue;
                }
                //calculate how many we still need to compose the triplet
                var remain = 0 - nums[i];
                //update the previous number
                pre = nums[i];
                //the previous tracking for inner loop
                var prev = 0;
                for (var j = i - 1; j > 0; j--)
                {
                    //same as outer loop, if number is same
                    //would yield same triplet, skip it.
                    if (j != i - 1 && nums[j] == prev)
                    {
                        continue;
                    }
                    //calculate the last number needed
                    var last = remain - nums[j];
                    //update the previous
                    prev = nums[j];
                    //binary search the last number
                    var exist = Array.BinarySearch<int>(nums, 0, j, last);
                    //if found add the triplet
                    if (exist >= 0)
                    {
                        reslist.Add(new List<int>() { nums[i], nums[j], last });
                    }
                }
            }
            return reslist;
        }












    }
}
