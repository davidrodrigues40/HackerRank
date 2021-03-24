using System;
using System.Linq;

namespace Core.Problems
{
    public class BirthdayCakeCandles : IWorker
    {
        public void DoWork(object input)
        {
            var strArray = input.ToString().Split(',');
            var arr = strArray.Select<string, int>(int.Parse).ToArray();
            var candles = arr.ToList();

            var max = candles.Max();
            Console.WriteLine(candles.Count(a => a == max));
        }
    }
}
