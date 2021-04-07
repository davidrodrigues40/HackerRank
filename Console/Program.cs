using ConsoleApp.Factories;
using ConsoleApp.Services;
using Core.Problems;
using System;

namespace ConsoleApp
{
    class Program
    {
        private static readonly string[] _args = { "BreakingTheRecords", "3 4 21 36 10 28 35 5 24 42" };
        static void Main(string[] args)
        {
            var parser = new ArgParser();

            var parameters = parser.GetParameters(_args);

            var factory = new WorkerFactory();
            IWorker worker = (IWorker)factory.GetWorker(parameters.Problem);
            worker.DoWork(parameters.Input);

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
