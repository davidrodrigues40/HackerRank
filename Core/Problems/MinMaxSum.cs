using Core.Services;
using System;
using System.Linq;

namespace Core.Problems
{
    public class MinMaxSum : IWorker
    {
        public void DoWork(object a)
        {
            var strArray = a.ToString().Split(' ');
            int[] arr = strArray.Select<string, int>(int.Parse).ToArray();


            Console.WriteLine($"{SumService.MinSum(arr)} {SumService.MaxSum(arr)}");
        }
    }
}
