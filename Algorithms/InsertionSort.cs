namespace ArraySort.Algorithms;

public class InsertionSort
{
    public int Comparisons { get; private set; }
    public int Swaps { get; private set; }

    public void Sort(int[] arr)
    {
        Comparisons = 0;
        Swaps = 0;
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            Comparisons++;

            while (j >= 0 && arr[j] > key)
            {
                Comparisons++;
                Swaps++;
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;
        }
    }
}
