using System.Diagnostics;

namespace project_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new();
            List<int> items = [12, 11, 13, 5, 6];
            InsertionSort<int> insertionSort = new();
            stopwatch.Start();
            insertionSort.Sort(items);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }
    }
}
