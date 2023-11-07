namespace ArraySort.Algorithms;

public class ShellSort
{
    public double Comparisons { get; private set; }
    public double Swaps { get; private set; }

    public void Sort(int[] arr)
    {
        Comparisons = 0;
        Swaps = 0;
        int n = arr.Length;

        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j;

                for (j = i; j >= gap; j -= gap)
                {
                    Comparisons++;
                    if (arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        Swaps++;
                    }
                    else
                    {
                        break;
                    }
                }

                arr[j] = temp;
            }
        }
    }
}