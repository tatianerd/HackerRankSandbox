namespace HackerRankSandbox.Challenges
{
    internal static class MinimumSwaps2
    {
        public static int minimumSwaps(int[] arr)
        {
            int j;
            int c = arr.Length;
            int swaps = 0;
            for (var i = 0; i < c; i++)
            {
                j = i + 1;
                while (j < c)
                {
                    if (arr[i] < arr[j])
                    {
                        j++;
                    }
                    else
                    {
                        if (arr[i] >= j)
                            swaps++;
                        j++;

                    }
                }
            }

            return swaps;
        }

        public static int minimumSwapsSolution(int[] arr)
        {
            int min_index = 0;
            int min = arr[0];
            int swaps = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min_index = i;
                    min = arr[i];
                }
            }

            if (min_index != 0)
            {
                int temp = arr[0];
                arr[0] = arr[min_index];
                arr[min_index] = temp;
                swaps++;
            }
            for (int cur = 1; cur < arr.Length - 1; cur++)
            {
                int pos = arr[cur] - arr[0];
                while (arr[pos] != arr[cur])
                {
                    int temp = arr[pos];
                    arr[pos] = arr[cur];
                    arr[cur] = temp;
                    swaps++;
                    pos = arr[cur] - arr[0];
                }
                cur = pos;
            }

            return swaps;

        }
    }
}

