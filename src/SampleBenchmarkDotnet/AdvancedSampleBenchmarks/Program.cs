using BenchmarkDotNet.Running;

namespace AdvancedSampleBenchmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BenchmarkRunner.Run<CollectionIteration>();
        }
    }
}