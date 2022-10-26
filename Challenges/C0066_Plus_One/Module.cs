using System.Diagnostics;

namespace Challenges.C0066_Plus_One
{
    internal class Module
    {
        public int[] PlusOne(int[] digits)
        {
            int remainder = 1;
            var result = new List<int>();

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int thisDigit = digits[i] + remainder;
                remainder = 0;

                if (thisDigit > 9)
                {
                    result.Insert(0, thisDigit % 10);
                    remainder = 1;
                }
                else
                {
                    result.Insert(0, thisDigit);
                }
            }

            if (remainder > 0)
            {
                result.Insert(0, remainder);
            }

            return result.ToArray();
        }
    }
}
