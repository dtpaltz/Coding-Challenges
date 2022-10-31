namespace Challenges.C1346_Check_N_and_Double_Exist
{
    internal class Module
    {
        public bool CheckIfExist(int[] arr)
        {
            var foundRoster = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var item = arr[i];

                if (!foundRoster.ContainsKey(item))
                {
                    foundRoster.Add(item, i);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                var item = arr[i];

                if (foundRoster.ContainsKey(item * 2) && foundRoster[item * 2] != i)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
