using CommonLibrary.Grid;
using NUnit.Framework;

namespace Challenges.C0005_MazeSolving
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
            var m = new DemolishGrid();

            m.IsGridSolvable();
        }
    }
}