namespace ArraySort.Algorithms;

public class BubbleSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 1; i < n; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    // Troca os elementos arr[i-1] e arr[i]
                    (arr[i - 1], arr[i]) = (arr[i], arr[i - 1]);
                    swapped = true;
                }
            }
        } while (swapped);
    }
}