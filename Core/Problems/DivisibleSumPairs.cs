using Core.Helpers;
using Core.Services;
using Newtonsoft.Json;
using System;

namespace Core.Problems
{
    public class DivisibleSumPairs : IProblem
    {
        public void Solve(object input)
        {
            string[] p = input.ToStringList(' ');
            var n = int.Parse(p[1]);
            var k = int.Parse(p[2]);
            var ar = JsonConvert.DeserializeObject<int[]>(p[0]);

            Console.WriteLine(divisibleSumPairs(n, k, ar));
        }
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            return SumService.NumberOfSumPairs(k, ar);
        }
    }
}
