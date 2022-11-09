using System.Diagnostics;

namespace Lula.C02_First_Unique_Char
{
    internal class Module
    {
        public char FirstUnichiqueChar(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                var charTally = new Dictionary<char, int>();

                foreach (char c in str)
                {
                    if (!charTally.ContainsKey(c))
                    {
                        charTally.Add(c, 0);
                    }

                    charTally[c]++;
                }

                foreach (char c in str)
                {
                    if (charTally[c] == 1)
                    {
                        return c;
                    }
                }
            }

            return '\0';
        }
    }
}
