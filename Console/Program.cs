using ConsoleApp.Factories;
using ConsoleApp.Models;
using ConsoleApp.Services;
using Core.Problems;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        private static readonly string[] Args = { "PickingNumbers", "1 2 2 3 1 2" };

        private static void Main(string[] args)
        {
            var parser = new ArgParser();

            Parameters parameters = parser.GetParameters(Args);

            var factory = new WorkerFactory();
            var worker = (IProblem)factory.GetWorker(parameters.Problem);
            worker.Solve(parameters.Input);

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}