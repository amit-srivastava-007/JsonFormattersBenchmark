using BenchmarkDotNet.Running;
using System;

namespace JsonFormattersBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Deserialization");

            var summary = BenchmarkRunner.Run(typeof(BenchmarkExecutorLargeDataSet));

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
