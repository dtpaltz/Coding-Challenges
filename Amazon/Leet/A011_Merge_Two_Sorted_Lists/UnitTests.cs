using CommonLibrary.LinkedList;
using NUnit.Framework;

namespace Amazon.A011_Merge_Two_Sorted_Lists
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
            var m = new Module();
            var arg1 = new ListNode(new int[] { 1, 2, 4 });
            var arg2 = new ListNode(new int[] { 1, 3, 4 });

            var result = m.MergeTwoLists(arg1, arg2);
        }
    }
}