using Core.Problems;
using System;

namespace ConsoleApp.Factories
{
    public class WorkerFactory
    {
        public static IProblem GetWorker(string problem)
        {
            string sType = $"Core.Problems.{problem}, Core";
            var type = Type.GetType(sType);

            return (IProblem)Activator.CreateInstance(type);
        }
    }
}
