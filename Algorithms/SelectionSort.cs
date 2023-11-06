namespace ArraySort.Algorithms;

public class SelectionSort
{
    public int Comparisons { get; private set; }
    public int Swaps { get; private set; }

    public void Sort(int[] arr)
    {
        Comparisons = 0;
        Swaps = 0;
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                Comparisons++;
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                Swaps++;
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
        }
    }
}