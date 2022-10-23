namespace Amazon.OA002_Reorder_Data
{
    internal class Module
    {
        public string[] ReorderData(string[] logs)
        {
            var digitLogs = new List<string>();
            var lettrLogs = new Dictionary<string, string>();

            foreach (var l in logs)
            {
                if (long.TryParse(l.Split(' ').Last(), out _))
                {
                    digitLogs.Add(l);
                }
                else
                {
                    lettrLogs.Add(l.Split(' ').First(), l.Substring(l.IndexOf(' ') + 1));
                }
            }

            var lettrLogsSorted = lettrLogs.OrderBy(e => e.Value).ThenBy(e => e.Key).Select(e => e.Key + ' ' + e.Value).ToList();

            var result = lettrLogsSorted.Concat(digitLogs).ToArray();
            return result;
        }
    }
}
