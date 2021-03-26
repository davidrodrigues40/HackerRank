using ConsoleApp.Factories;
using ConsoleApp.Services;
using Core.Problems;
using System;

namespace ConsoleApp
{
    class Program
    {
        private static readonly string[] _args = { "AppleAndOrange", "7 11 5 15 -2,2,1 5,-6" };
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

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
