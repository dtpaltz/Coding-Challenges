using System.Diagnostics;

namespace Challenges.C0001_FizzBuzz
{
    internal class Module
    {
        public void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string fizz = "Fizz";
                string buzz = "Buzz";
                string result = i + "";

                bool check3 = i % 3 == 0;
                bool check5 = i % 5 == 0;

                if (check3 && check5)
                {
                    result = fizz + buzz;
                }
                else if (check3)
                {
                    result = fizz;
                }
                else if (check5)
                {
                    result = buzz;
                }

                Debug.WriteLine(result);
            }
        }
    }
}
