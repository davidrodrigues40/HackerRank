using Core.Helpers;
using Core.Services;
using System;

namespace Core.Problems
{
    public class NumberLineJumps : IWorker
    {
        public void DoWork(object input)
        {
            int[] strArray = input.ToIntArray(' ');
            int x1 = strArray[0];
            int v1 = strArray[1];
            int x2 = strArray[2];
            int v2 = strArray[3];

            Console.WriteLine(KagarooService.Race(x1, v1, x2, v2));
        }
    }
}
