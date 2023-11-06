using System.Diagnostics;
using ArraySort.Algorithms;
using ArraySort.Model;

int[] sizes = { 1000, 10000, 100000 };
object[] algorithms = { new BubbleSort(), new ImprovedBubbleSort() };

foreach (object algorithm in algorithms)
{
    Console.WriteLine("\n--------------------------------------------------");
    Console.WriteLine($"{algorithm.GetType().Name.ToUpper()}");
    Console.WriteLine("--------------------------------------------------");
    
    foreach (int size in sizes)
    {
        int[] ascending = CreateArray.Ascending(size);
        int[] random = CreateArray.Random(size);
        int[] descending = CreateArray.Descending(size);
        
        Console.WriteLine($"************************\n{size} elementos\n************************");
        
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        algorithm.GetType().GetMethod("Sort").Invoke(algorithm, new object[] { ascending });
        stopwatch.Stop();
        Console.WriteLine($"Ordenado: {stopwatch.Elapsed.ToString(@"m\:ss\.fff")}");

        stopwatch.Reset();
        stopwatch.Start();
        algorithm.GetType().GetMethod("Sort").Invoke(algorithm, new object[] { random });
        stopwatch.Stop();
        Console.WriteLine($"Aleatório: {stopwatch.Elapsed.ToString(@"m\:ss\.fff")}");

        stopwatch.Reset();
        stopwatch.Start();
        algorithm.GetType().GetMethod("Sort").Invoke(algorithm, new object[] { descending });
        stopwatch.Stop();
        Console.WriteLine($"Decrescente: {stopwatch.Elapsed.ToString(@"m\:ss\.fff")}\n");
    }
}