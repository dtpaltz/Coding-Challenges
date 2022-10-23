using NUnit.Framework;

namespace Amazon.OA003_K_Most_Freq_Words
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
            var words = new List<string>()
            {
                "aa",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "cc",
                "cc",
                "cc",
                "cc",
                "cc",
                "cc",
                "cc",
                "dd",
                "dd",
                "dd",
                "dd",
                "dd",
                "dd",
                "dd",
                "dd",
                "dd",
                "dd",
                "dd",
                "dd",
                "dd",
                "ee",
                "ff"
            };

            m.FreqWords(words, 3);
        }
    }
}