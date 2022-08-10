using NUnit.Framework;

namespace Challenges.C0017_Print_Tree_Level
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            theRoot = new Node(0);
            theRoot.left = new Node(1);
            theRoot.right = new Node(2);
            theRoot.left.left = new Node(3);
            theRoot.left.right = new Node(4);
            theRoot.right.right = new Node(5);
        }

        Node theRoot;

        [Test]
        public void Test1()
        {
            var m = new TreePrinter();

            m.PrintLevel(theRoot, 1);
            m.PrintLevel(theRoot, 2);
        }

        

    }
}