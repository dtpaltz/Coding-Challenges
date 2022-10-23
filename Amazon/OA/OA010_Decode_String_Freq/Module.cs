namespace Amazon.OA010_Decode_String_Freq
{
    internal class Module
    {
        public string DecodeCharFreq(string code)
        {
            var result = new int[26];

            string decoded = "";
            string freqCntBuild = "";
            string charBuild = "";

            for (int i = code.Length - 1; i >= 0; i--)
            {
                var dummyCurrChar = code[i].ToString();

                if (code[i] == ')')
                {
                    for (int j = 1; j < (code.Length); j++)
                    {
                        var currChar = code[i - j];
                        if (char.IsNumber(currChar))
                        {
                            freqCntBuild = currChar + freqCntBuild;
                        }
                        else
                        {
                            i -= j;
                            break;
                        }
                    }
                }
                else if (code[i] == '#')
                {
                    charBuild = code[(i - 2)..(i)];
                    i -= 2;
                }
                else
                {
                    charBuild = code[i].ToString();
                }

                if (!string.IsNullOrEmpty(charBuild))
                {
                    if (string.IsNullOrEmpty(freqCntBuild))
                    {
                        freqCntBuild = "1";
                    }

                    int charIdx = int.Parse(charBuild) - 1;
                    int freq = int.Parse(freqCntBuild);
                    result[charIdx] += freq;

                    decoded = (new string(Convert.ToChar(97 + charIdx), freq)) + decoded;

                    charBuild = "";
                    freqCntBuild = "";
                }
            }

            return decoded;
        }
    }
}
