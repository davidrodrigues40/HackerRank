using Core.Helpers;
using Core.Services;
using System;

namespace Core.Problems
{
    public class BreakingTheRecords : IWorker
    {
        public void DoWork(object input)
        {
            Console.WriteLine(breakingRecords(input.ToIntArray(' ')).ToOneLineString());
        }

        private int[] breakingRecords(int[] scores)
        {
            var value = RecordService.RecordsBroken(scores);
            return new[] { value.max, value.min };
        }
    }
}
