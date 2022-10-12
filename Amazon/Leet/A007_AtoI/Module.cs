namespace Amazon.A007_AtoI
{
    internal class Module
    {
        public int MyAtoi(string s)
        {
            s = s.TrimStart();
            string buildStr = "";
            bool isNeg = s.StartsWith('-');

            if (s.StartsWith('-') || s.StartsWith('+'))
            {
                s = s[1..];
            }

            for (int i = 0; i < s.Length; i++)
            {
                var currChar = s[i];

                if (Char.IsDigit(currChar))
                {
                    buildStr += currChar;
                }
                else
                {
                    break;
                }
            }

            if (string.IsNullOrEmpty(buildStr))
            {
                return 0;
            }

            int result = int.MaxValue;

            try
            {
                result = int.Parse(buildStr);

                if (isNeg)
                {
                    result *= -1;
                }
            }
            catch (OverflowException)
            {
                if (isNeg)
                {
                    result = int.MinValue;
                }
            }

            return result;
        }
    }
}
