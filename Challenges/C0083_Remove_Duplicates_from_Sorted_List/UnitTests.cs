using CommonLibrary.LinkedList;
using NUnit.Framework;

namespace Challenges.C0083_Remove_Duplicates_from_Sorted_List
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

            m.DeleteDuplicates(null);
        }

        [Test]
        public void Test2()
        {
            var m = new Module();

            m.DeleteDuplicates(new ListNode());
        }

        [Test]
        public void Test3()
        {
            var m = new Module();

            var arg = new ListNode(new int[] { 1, 2, 2, 2, 3, 3, 3, 4, 5 });

            m.DeleteDuplicates(arg);
        }

    }
}