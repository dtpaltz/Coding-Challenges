namespace Challenges.C0016_Sentence_Valid_Words
{
    internal class Module
    {
        public int CountValidWords(string sentence)
        {
            var tokens = sentence.Split(' ').Where(t => !string.IsNullOrEmpty(t));
            int validCount = 0;

            foreach (var t in tokens)
            {
                if (IsValidToken(t))
                {
                    validCount++;
                }
            }

            return validCount;
        }

        static bool IsValidToken(string token)
        {
            var puncs = new HashSet<char>() { '!', '.', ',' };

            if (token[0] == '-' || token[token.Length - 1] == '-')
            {
                return false;
            }

            int hyphenCount = 0;
            int puncCount = 0;

            for (int i = 0; i < token.Length; i++)
            {
                var ch = token[i];

                if (ch == '-')
                {
                    hyphenCount++;

                    if (hyphenCount > 1)
                    {
                        return false;
                    }

                    if (!(char.IsLetter(token[i - 1]) && char.IsLetter(token[i + 1])))
                    {
                        return false;
                    }
                }
                else if (puncs.Contains(ch))
                {
                    if (i != token.Length - 1)
                    {
                        return false;
                    }

                    puncCount++;

                    if (puncCount > 1)
                    {
                        return false;
                    }
                }
                else if (char.IsDigit(ch))
                {
                    return false;
                }
                else if (char.IsUpper(ch))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
