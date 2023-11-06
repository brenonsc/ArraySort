namespace ArraySort.Model;

public class CreateArray
{
    public static int[] Ascending(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = i;
        }
        return array;
    }

    public static int[] Random(int size)
    {
        Random rand = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next();
        }
        return array;
    }

    public static int[] Descending(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = size - i - 1;
        }
        return array;
    }
}