using System.Diagnostics;

namespace Challenges.C0013_BuddyStrings
{
    internal class Module
    {
        public bool BuddyStrings(string s, string goal)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(goal) || (s.Length != goal.Length))
            {
                return false;
            }
            
            if (s == goal)
            {
                var uniqueCh = new HashSet<char>();

                foreach (var item in s)
                {
                    uniqueCh.Add(item);
                }

                if (uniqueCh.Count < s.Length)
                {
                    return true;
                }

                return false;
            }

            var diffs = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != goal[i])
                {
                    diffs.Add(i);
                }
            }

            if (diffs.Count == 2 && s[diffs[0]] == goal[diffs[1]] && s[diffs[1]] == goal[diffs[0]])
            {
                return true;
            }

            return false;
        }
    }
}
