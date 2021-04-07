using Core.Helpers;
using System;
using System.Linq;

namespace Core.Problems
{
    public class BirthdayCakeCandles : IWorker
    {
        public void DoWork(object input)
        {
            var strArray = input.ToString().Split(' ');
            var arr = strArray.Select(int.Parse).ToArray();

            Console.WriteLine(arr.CountMax());
        }
    }
}
