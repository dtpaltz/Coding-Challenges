using CommonLibrary.LinkedList;
using NUnit.Framework;

namespace Amazon.A002_AddTwoNumbers
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
            Module m = new Module();

            var node1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            var node2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            m.AddTwoNumbers(node1, node2);
        }
    }
}