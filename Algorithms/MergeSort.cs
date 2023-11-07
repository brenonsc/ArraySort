namespace ArraySort.Algorithms;

public class MergeSort
{
    public double Comparisons { get; private set; }
    public double Merges { get; private set; }

    public void Sort(int[] arr)
    {
        Comparisons = 0;
        Merges = 0;
        MergeSortRecursive(arr, 0, arr.Length - 1);
    }

    private void MergeSortRecursive(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSortRecursive(arr, left, mid);
            MergeSortRecursive(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    private void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = arr[left + i];

        for (int i = 0; i < n2; i++)
            rightArray[i] = arr[mid + 1 + i];

        int leftIndex = 0, rightIndex = 0, mergedIndex = left;

        while (leftIndex < n1 && rightIndex < n2)
        {
            Comparisons++;
            if (leftArray[leftIndex] <= rightArray[rightIndex])
            {
                arr[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                arr[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
            }
            Merges++;
            mergedIndex++;
        }

        while (leftIndex < n1)
        {
            arr[mergedIndex] = leftArray[leftIndex];
            leftIndex++;
            mergedIndex++;
            Merges++;
        }

        while (rightIndex < n2)
        {
            arr[mergedIndex] = rightArray[rightIndex];
            rightIndex++;
            mergedIndex++;
            Merges++;
        }
    }
}