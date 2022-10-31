using System.Diagnostics;

namespace Challenges.C2423_Remove_Letter_to_Equalize
{
    internal class Module
    {
        public bool EqualFrequency(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            var roster = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                var item = word[i];
                if (!roster.ContainsKey(item))
                {
                    roster.Add(item, 0);
                }

                roster[item]++;
            }

            if (roster.Count == 1)
            {
                return true;
            }

            var freqDeltas = roster.Values.Distinct().ToArray();
            if (freqDeltas.Length == 1 && freqDeltas[0] == 1)
            {
                return true;

            }
            else if (freqDeltas.Length != 2)
            {
                return false;
            }

            // calculate for low end            var lowEnd = roster.ToDictionary(entry => entry.Key, entry => entry.Value);

            var largestValKey = lowEnd.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            lowEnd[largestValKey]--;

            var lowEndDeltas = lowEnd.Values.Distinct().Where(x => x > 0).ToArray();

            // calculate for high end
            var highEnd = roster.ToDictionary(entry => entry.Key, entry => entry.Value);

            var smallestValKey = highEnd.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
            highEnd[smallestValKey]--;

            var highEndDeltas = highEnd.Values.Distinct().Where(x => x > 0).ToArray();

            return lowEndDeltas.Length == 1 || highEndDeltas.Length == 1;
        }
    }
}
