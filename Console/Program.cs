using ConsoleApp.Factories;
using ConsoleApp.Models;
using ConsoleApp.Services;
using Core.Problems;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        private static readonly string[] Args = { "SaveThePrisoner" };

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Console App");
            var parser = new ArgParser();
            string[] arguments = args.Length > 0 ? args : Args;

            Parameters parameters = parser.GetParameters(ArgGenerator.GetArguments(arguments[0]));

            Console.WriteLine($"Running Problem {parameters.Problem}");

            Run(parameters);
        }

        private static void Run(Parameters parameters)
        {
            while (true)
            {
                IProblem worker = WorkerFactory.GetWorker(parameters.Problem);

                worker.Solve(parameters.Input);

                Console.WriteLine("Press Q to quit");
                var key = Console.ReadKey();

                if (key.Key.ToString().ToLower() == "q")
                    End();
                else
                    continue;
                break;
            }
        }

        private static void End()
        {
            GC.Collect();
        }
    }
}