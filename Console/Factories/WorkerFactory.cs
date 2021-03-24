using System;

namespace ConsoleApp.Factories
{
    public enum Problem
    {
        None,
        StairCase,
        MinMaxSum,
        BirthdayCakeCandles,
        TimeConversion,
        FindDigits,
        ExtraLongFactorials,
        AppendAndDelete,
        CutTheSticks
    }
    public class WorkerFactory
    {
        public object GetWorker(Problem problem)
        {
            string sType = $"Core.Problems.{problem.ToString()}, Core";
            var type = Type.GetType(sType);

            return Activator.CreateInstance(type);
        }
    }
}
