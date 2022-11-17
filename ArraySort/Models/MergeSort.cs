namespace ArraySort.Models;

public class MergeSort
{
    public void CreateArray(int arraySize)
    {
        int[] array = new int[arraySize];

        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.Next(0, arraySize);
        }

        Sort(array, 0, arraySize - 1);
    }
    
    public void Merge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[numbers.Length];
        int i, leftEnd, numElements, tmpPos;
        leftEnd = (mid - 1);
        tmpPos = left;
        numElements = (right - left + 1);
        while ((left <= leftEnd) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[tmpPos++] = numbers[left++];
            else
                temp[tmpPos++] = numbers[mid++];
        }

        while (left <= leftEnd)
            temp[tmpPos++] = numbers[left++];
        while (mid <= right)
            temp[tmpPos++] = numbers[mid++];
        for (i = 0; i < numElements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    public void Sort(int[] array, int leftIndex, int rightIndex)
    {
        int midIndex;
        if (rightIndex > leftIndex)
        {
            midIndex = (rightIndex + leftIndex) / 2;
            Sort(array, leftIndex, midIndex);
            Sort(array, (midIndex + 1), rightIndex);
            Merge(array, leftIndex, (midIndex + 1), rightIndex);
        }
    }
}