namespace ArraySort.Models;

public class QuickSort
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
    
    public void Sort(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];
        
        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }
        
            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }
        }
    
        if (leftIndex < j)
            Sort(array, leftIndex, j);
        if (i < rightIndex)
            Sort(array, i, rightIndex);
    }
}