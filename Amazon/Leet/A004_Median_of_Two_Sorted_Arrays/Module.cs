namespace Amazon.A004_Median_of_Two_Sorted_Arrays
{
    internal class Module
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var ma = MergeArrays(nums1, nums2);

            int midIdx = ma.Length / 2;
            double result = ma[midIdx];

            if (ma.Length % 2 == 0)
            {
                result += ma[midIdx - 1];
                result /= 2.0;
            }

            return result;
        }

        // Merge arr1[0..n1-1] and
        // arr2[0..n2-1] into
        // arr3[0..n1+n2-1]
        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            // Traverse both array
            while (i < arr1.Length && j < arr2.Length)
            {
                // Check if current element
                // of first array is smaller
                // than current element
                // of second array. If yes,
                // store first array element
                // and increment first array
                // index. Otherwise do same
                // with second array
                if (arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];
                else
                    arr3[k++] = arr2[j++];
            }

            // Store remaining
            // elements of first array
            while (i < arr1.Length)
                arr3[k++] = arr1[i++];

            // Store remaining elements
            // of second array
            while (j < arr2.Length)
                arr3[k++] = arr2[j++];

            return arr3;
        }


        // this does not support duplicate entries/keys
        static int[] MergeArraysBeta(int[] a, int[] b)
        {
            // Declaring a map.
            // using map as a inbuilt tool
            // to store elements in sorted order.
            SortedDictionary<int, Boolean> mp = new SortedDictionary<int, Boolean>();

            // Inserting values to a map.
            for (int i = 0; i < a.Length; i++)
            {
                mp.Add(a[i], true);
            }

            for (int i = 0; i < b.Length; i++)
            {
                mp.Add(b[i], true);
            }

            var result = mp.Keys.ToArray();
            return result;
        }
    }
}
