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
        CutTheSticks,
        GradingStudents,
        AppleAndOrange,
        NumberLineJumps
    }
    public class WorkerFactory
    {
        public object GetWorker(string problem)
        {
            string sType = $"Core.Problems.{problem}, Core";
            var type = Type.GetType(sType);

            return Activator.CreateInstance(type);
        }
    }
}
