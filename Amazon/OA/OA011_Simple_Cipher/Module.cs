namespace Amazon.OA011_Simple_Cipher
{
    internal class Module
    {
        public string DecodeCipher(string code, int k)
        {
            string result = "";

            for (int i = 0; i < code.Length; i++)
            {
                char currChar = code[i];
                int newCharIdx = (int)currChar;

                if (newCharIdx - k < 65)
                {
                    newCharIdx = 91;
                }

                newCharIdx -= k;

                result += Convert.ToChar(newCharIdx);
            }

            return result;
        }
    }
}
