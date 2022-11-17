using ArraySort.Models;
using System.Diagnostics;

SelectionSort selection = new SelectionSort();
InsertionSort insertion = new InsertionSort();
QuickSort quick = new QuickSort();
MergeSort merge = new MergeSort();

string[] array = new string[4] {"SELECTION", "INSERTION", "QUICK", "MERGE"};

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"\n\n{array[i]} SORT");
    for (int j = 100; j <= 100000; j = j * 10)
    {
        Console.Write($"\nTAMANHO DA AMOSTRA: {j}\n");
        for (int k = 0; k < 10; k++)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            if (i == 0)
            {
                selection.Sort(j);
            }
            
            else if (i == 1)
            {
                insertion.Sort(j);
            }

            else if (i == 2)
            {
                quick.CreateArray(j);
            }

            else
            {
                merge.CreateArray(j);
            }

            stopWatch.Stop();

            Console.WriteLine($"Tempo de ordenação {k + 1}: {stopWatch.Elapsed}");
        }
    }
}
