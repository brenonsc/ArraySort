namespace ArraySort.Algorithms;

public class ImprovedBubbleSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Troca os elementos arr[j] e arr[j+1]
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }
            }

            // Se nenhum elemento foi trocado nesta iteração, o vetor está ordenado
            if (!swapped)
                break;
        }
    }
}