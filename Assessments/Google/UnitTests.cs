using NUnit.Framework;

namespace Assessments.Google
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Add_1()
        {
            string exprsn = "2 5 +";
            double expAns = 7.0;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Add_2()
        {
            string exprsn = "2.5 5 +";
            double expAns = 7.5;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Add_3()
        {
            string exprsn = "2.5 5.2 +";
            double expAns = 7.7;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Subtract_1()
        {
            string exprsn = "10 3 -";
            double expAns = 7.0;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Subtract_2()
        {
            string exprsn = "2 5 -";
            double expAns = -3.0;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Subtract_3()
        {
            string exprsn = "2.7 5.2 -";
            double expAns = -2.5;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Subtract_4()
        {
            string exprsn = "5 2 -";
            double expAns = 3.0;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Mult_1()
        {
            string exprsn = "10 3 *";
            double expAns = 30.0;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Mult_2()
        {
            string exprsn = "2.5 3 *";
            double expAns = 7.5;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Mult_3()
        {
            string exprsn = "-2.2 3.3 *";
            double expAns = -7.26;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Divide_1()
        {
            string exprsn = "15 3 /";
            double expAns = 5.0;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Divide_2()
        {
            string exprsn = "100 25 /";
            double expAns = 4.0;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Power_1()
        {
            string exprsn = "4 2 ^";
            double expAns = 16.0;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Complex_1()
        {
            string exprsn = "1 2 * 3 +";
            double expAns = 5.0;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Complex_2()
        {
            string exprsn = "3 4 * 2 5 * +";
            double expAns = 22.0;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }

        [Test]
        public void Test_Complex_3()
        {
            string exprsn = "2 5 3 6 + * * 5 / 2 -";
            double expAns = 16.0;
            var calc = new PostfixCalculator();

            Assert.That(calc.SolvePostFix(exprsn), Is.EqualTo(expAns));
        }
    }
}