namespace Amazon.A006_Zigzag_Conversion
{
    internal class Module
    {
        public string Convert(string s, int numRows)
        {
            if (numRows <= 1)
            {
                return s;
            }

            List<char>[] rows = new List<char>[numRows];

            for (int i = 0; i < numRows; i++)
            {
                rows[i] = new List<char>();
            }

            int currRow = 0;
            int direction = 1;

            foreach (var c in s)
            {
                rows[currRow].Add(c);
                currRow += direction;

                if (currRow == 0 || currRow == numRows - 1)
                {
                    direction *= -1;
                }
            }

            string result = string.Empty;

            foreach (var item in rows)
            {
                var myString = new string(item.ToArray());
                result += myString;
            }

            return result;
        }
    }
}
