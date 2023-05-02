using ConsoleApp.Factories;
using ConsoleApp.Models;
using ConsoleApp.Services;
using Core.Problems;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        private static readonly string[] Args = { "ClimbingLeaderBoard" };

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Console App");
            var parser = new ArgParser();
            string[] arguments = args.Length > 0 ? args : Args;

            Parameters parameters = parser.GetParameters(ArgGenerator.GetArguments(arguments[0]));

            Console.WriteLine($"Running Problem {parameters.Problem}");
            Console.WriteLine($"With values {parameters.Input}");

            Run(parameters);
        }

        private static void Run(Parameters parameters)
        {
            var factory = new WorkerFactory();
            var worker = (IProblem)factory.GetWorker(parameters.Problem);

            worker.Solve(parameters.Input);

            Console.WriteLine("Press Q to quit");
            var key = Console.ReadKey();

            if (key.Key.ToString().ToLower() == "q")
                return;
            else
                Run(parameters);
        }
    }
}