#if NET48
using System;
#endif
using BenchmarkDotNet.Running;

namespace BemchmarkSimpleJob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, BenchmarkDotnet!");
            BenchmarkRunner.Run<Md5VsSha256>();
        }
    }
}