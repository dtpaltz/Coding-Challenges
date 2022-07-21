using NUnit.Framework;

namespace Assessments.Deepcell
{
    public class Tests
    {
        static bool isSetup = false;
        static string largeSeqA = "ACTGACTG";
        static string largeSeqB = "";

        [SetUp]
        public void Setup()
        {
            if (!isSetup)
            {
                int limit = (int)(int.MaxValue * 0.00002);
                for (int i = 0; i < limit; i++)
                {
                    largeSeqB += largeSeqA;
                }

                isSetup = true;
            }
        }

        [Test, Timeout(6000)]
        public void Test1()
        {
            Module m = new Module();
            int result = m.FindSmallestCommonDnaSubsequenceLength(largeSeqA, largeSeqB);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Test2()
        {
            string x = "ATC";
            string y = "ATCATCATCATC";

            Module m = new Module();
            int result = m.FindSmallestCommonDnaSubsequenceLength(x, y);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}