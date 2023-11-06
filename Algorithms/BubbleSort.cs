namespace ArraySort.Algorithms;

public class BubbleSort
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
            for (int j = 0; j < n - i - 1; j++)
            {
                Comparisons++;
                if (arr[j] > arr[j + 1])
                {
                    Swaps++;
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
    }
}