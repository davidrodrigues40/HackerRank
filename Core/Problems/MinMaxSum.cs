using System;
using System.Linq;

namespace Core.Problems
{
    public class MinMaxSum : IWorker
    {
        public void DoWork(object a)
        {
            var strArray = a.ToString().Split(',');
            int[] arr = strArray.Select<string, int>(int.Parse).ToArray();
            var list = arr.ToList();

            var lowestNum = arr.ToList().Min();
            var highestNum = arr.ToList().Max();
            long lowOutput = 0;
            long highOutput = 0;

            list.Remove(highestNum);
            lowOutput = list.Sum();
            list.Add(highestNum);
            list.Remove(lowestNum);
            highOutput = list.Sum(v => (long)v);


            Console.WriteLine($"{lowOutput} {highOutput}");
        }
    }
}
