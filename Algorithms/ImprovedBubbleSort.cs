namespace ArraySort.Algorithms;

public class ImprovedBubbleSort
{
    public double Comparisons { get; private set; }
    public double Swaps { get; private set; }

    public void Sort(int[] arr)
    {
        Comparisons = 0;
        Swaps = 0;
        int n = arr.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                Comparisons++;
                if (arr[j] > arr[j + 1])
                {
                    Swaps++;
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }
}