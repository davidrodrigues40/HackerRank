using ConsoleApp.Factories;
using ConsoleApp.Services;
using Core.Problems;
using System;

namespace ConsoleApp
{
    class Program
    {
        private static readonly string[] _args = { "CatsAndAMouse", "[1,3,2] [1,2,3]" };
        static void Main(string[] args)
        {
            var parser = new ArgParser();

            var parameters = parser.GetParameters(_args);

            var factory = new WorkerFactory();
            IProblem worker = (IProblem)factory.GetWorker(parameters.Problem);
            worker.Solve(parameters.Input);

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
