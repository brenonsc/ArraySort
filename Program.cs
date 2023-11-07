using System.Diagnostics;
using ArraySort.Algorithms;
using ArraySort.Model;

int[] sizes = { 1000, 10000, 100000 };
object[] algorithms = { new BubbleSort(), new ImprovedBubbleSort(), new InsertionSort(), new SelectionSort(), new MergeSort(), new QuickSort() };

foreach (object algorithm in algorithms)
{
    Console.WriteLine("\n--------------------------------------------------");
    Console.WriteLine($"{algorithm.GetType().Name.ToUpper()}");
    Console.WriteLine("--------------------------------------------------");
    
    foreach (int size in sizes)
    {
        Console.WriteLine($"************************\n{size} elementos\n************************");
        
        int[] ascending = CreateArray.Ascending(size);
        int[] random = CreateArray.Random(size);
        int[] descending = CreateArray.Descending(size);
        
        Dictionary<int[], string> arrayNames = new Dictionary<int[], string>
        {
            { ascending, "ORDENADO" },
            { random, "ALEATÓRIO" },
            { descending, "DECRESCENTE" }
        };

        foreach (var entry in arrayNames)
        {
            int[] arr = entry.Key;
            string arrayName = entry.Value;
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            algorithm.GetType().GetMethod("Sort").Invoke(algorithm, new object[] { arr });
            stopwatch.Stop();
            try
            {
                Console.WriteLine($"{arrayName}:\nTempo: {stopwatch.Elapsed.ToString(@"m\:ss\.fff")}\nComparações: {algorithm.GetType().GetProperty("Comparisons").GetValue(algorithm)}\nTrocas: {algorithm.GetType().GetProperty("Swaps").GetValue(algorithm)}\n");
            }
            catch
            {
                Console.WriteLine($"{arrayName}:\nTempo: {stopwatch.Elapsed.ToString(@"m\:ss\.fff")}\nComparações: {algorithm.GetType().GetProperty("Comparisons").GetValue(algorithm)}\nMesclas: {algorithm.GetType().GetProperty("Merges").GetValue(algorithm)}\n");
            }
        }
    }
}