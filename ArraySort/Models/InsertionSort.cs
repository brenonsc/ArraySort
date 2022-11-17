namespace ArraySort.Models;

public class InsertionSort
{
    public void Sort(int arraySize)
    {
        int[] array = new int[arraySize];
        int number;
        int key;
        int j;
        
        Random randNum = new Random();
        
        for (int i = 0; i < array.Length; i++)
        {
            number = randNum.Next(0, arraySize);
            key = number;
            
            j = i;
        
            while(j > 0 && array[j-1]>key) 
            {
                array[j] = array[j-1];
                j--;
            }
        
            array[j] = key;
        }
        
        /*
        Console.Write("[ ");
        for(int i = 0; i < arraySize; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.Write("]");
        */
    }
}