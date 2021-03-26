using ConsoleApp.Factories;
using ConsoleApp.Services;
using Core.Problems;
using System;

namespace ConsoleApp
{
    class Program
    {
        private static readonly string[] _args = { "NumberLineJumps", "0 2 5 3" };
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
