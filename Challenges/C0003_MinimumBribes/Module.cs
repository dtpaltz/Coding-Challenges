using System.Diagnostics;

namespace Challenges.C0003_MinimumBribes
{
    internal class Module
    {
        public void minimumBribes(List<int> q)
        {
            int totalBribes = 0;
            int largestNumberBribes = 0;

            for (int c = q.Count; c > 0; c--)
            {
                if (q[c - 1] != c)
                {
                    int e = q.IndexOf(c);
                    int d = c - (e + 1);

                    totalBribes += d;

                    if (d > largestNumberBribes)
                    {
                        largestNumberBribes = d;
                    }

                    for (int i = e; i < (c - 1); i++)
                    {
                        (q[i], q[i + 1]) = (q[i + 1], q[i]);
                    }
                }
            }

            if (largestNumberBribes > 2)
            {
                Debug.WriteLine("Too chaotic");
            }
            else
            {
                Debug.WriteLine(totalBribes);
            }
            
        }
    }
}
