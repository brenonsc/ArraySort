namespace ArraySort.Algorithms;

public class QuickSort
{
    public double Comparisons { get; private set; }
    public double Swaps { get; private set; }

    public void Sort(int[] arr)
    {
        Comparisons = 0;
        Swaps = 0;
        QuickSortRecursive(arr, 0, arr.Length - 1);
    }

    private void QuickSortRecursive(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            QuickSortRecursive(arr, low, pivotIndex - 1);
            QuickSortRecursive(arr, pivotIndex + 1, high);
        }
    }

    private int Partition(int[] arr, int low, int high)
    {
        // Escolhe o elemento do meio como pivot
        int mid = (low + high) / 2;
        int pivot = arr[mid];

        // Troca o pivot com o último elemento
        Swap(arr, mid, high);

        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            Comparisons++;
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return i + 1;
    }

    private void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
        Swaps++;
    }
}