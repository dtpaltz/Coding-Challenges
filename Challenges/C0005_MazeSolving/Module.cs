using System.Diagnostics;

namespace Challenges.C0005_MazeSolving
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
                    int e = c - 1;

                    while (q[e] != c)
                    {
                        e--;
                    }

                    int d = c - (e + 1);

                    totalBribes += d;

                    if (d > largestNumberBribes)
                    {
                        largestNumberBribes = d;
                    }

                    q.RemoveAt(e);
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
