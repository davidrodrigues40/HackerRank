using Core.Helpers;
using System;
using System.Linq;

namespace Core.Problems
{
    public class BirthdayCakeCandles : IProblem
    {
        public void Solve(object input)
        {
            var strArray = input.ToString().Split(' ');
            var arr = strArray.Select(int.Parse).ToArray();

            Console.WriteLine(arr.CountMax());
        }
    }
}
