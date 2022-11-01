using System.Diagnostics;

namespace Challenges.C0069_Sqrt
{
    internal class Module
    {
        public int MySqrt(int x)
        {
            if (x < 2)
            {
                return x;
            }

            int start = 1;
            int end = x / 2;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if ((long)mid * mid > x)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return end;
        }
    }
}
