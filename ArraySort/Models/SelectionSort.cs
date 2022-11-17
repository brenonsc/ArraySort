using System.Diagnostics;
namespace ArraySort.Models;

public class SelectionSort
{
    public void Sort(int arraySize)
    {
        int[] array = new int[arraySize];

        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.Next(0, arraySize);
        }

        int tmp, min_key;
 
        for (int j = 0; j < arraySize - 1; j++)
        {
            min_key = j;
 
            for (int k = j + 1; k < arraySize; k++)
            {
                if (array[k] < array[min_key])
                {
                    min_key = k;
                }
            }
 
            tmp = array[min_key];
            array[min_key] = array[j];
            array[j] = tmp;
        }
    }
}