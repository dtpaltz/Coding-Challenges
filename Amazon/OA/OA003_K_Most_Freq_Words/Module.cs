namespace Amazon.OA003_K_Most_Freq_Words
{
    internal class Module
    {
        public List<string> FreqWords(List<string> words, int k)
        {
            var wordHits = new Dictionary<string, int>();

            foreach (var w in words.ConvertAll(d => d.ToLower()))
            {
                if (!wordHits.ContainsKey(w))
                {
                    wordHits.Add(w, 0);
                }

                wordHits[w]++;
            }

            var result = wordHits.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(p => p.Key).Take(k).ToList();
            return result;
        }
    }
}
