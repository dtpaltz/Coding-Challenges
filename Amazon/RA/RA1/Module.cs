namespace Amazon.RA1
{
    internal class Module
    {
        public int getMinMoves(List<int> plates)
        {
            int n = plates.Count;
            int[] temp = new int[n];
            var result = MergeSort(plates.ToArray(), temp, 0, n - 1);

            return result;
        }

        static int MergeArrs(int[] arr, int[] temp, int left, int mid, int right)
        {
            int swapCnt = 0;
            int i = left;
            int j = mid;
            int k = left;

            while ((i <= mid - 1) &&
                   (j <= right))
            {
                if (arr[i] <= arr[j])
                    temp[k++] = arr[i++];
                else
                {
                    temp[k++] = arr[j++];
                    swapCnt = swapCnt + (mid - i);
                }
            }

            while (i <= mid - 1)
                temp[k++] = arr[i++];

            while (j <= right)
                temp[k++] = arr[j++];

            for (i = left; i <= right; i++)
                arr[i] = temp[i];

            return swapCnt;
        }

        static int MergeSort(int[] arr, int[] temp, int left, int right)
        {
            int medium, swapCnt = 0;
            if (right > left)
            {
                medium = (right + left) / 2;
                swapCnt = MergeSort(arr, temp, left, medium);
                swapCnt += MergeSort(arr, temp, medium + 1, right);
                swapCnt += MergeArrs(arr, temp, left, medium + 1, right);
            }

            return swapCnt;
        }
    }
}
