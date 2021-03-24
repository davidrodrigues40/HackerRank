using ConsoleApp.Factories;
using ConsoleApp.Services;
using Core.Problems;
using System;

namespace ConsoleApp
{
    class Program
    {
        private static readonly string[] _args = { "AppendAndDelete", "aaaaaaaaaa aaaaa 7" };
        static void Main(string[] args)
        {
            var parser = new ArgParser();

            var parameters = parser.GetParameters(_args);

            if (parameters.Problem == Problem.None)
            {
                Console.WriteLine("Invalid Problem.");
            }

            var factory = new WorkerFactory();
            IWorker worker = (IWorker)factory.GetWorker(parameters.Problem);
            worker.DoWork(parameters.Input);

            Console.ReadKey();
        }
    }
}
