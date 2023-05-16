using Core.Helpers;
using Core.Services;
using Newtonsoft.Json;

namespace Core.Problems
{
    public class DivisibleSumPairs : IProblem
    {
        public object Solve(object input)
        {
            string[] p = input.ToStringList(' ');
            var n = int.Parse(p[1]);
            var k = int.Parse(p[2]);
            var ar = JsonConvert.DeserializeObject<int[]>(p[0]);

            return SumPairs(n, k, ar);
        }
        static int SumPairs(int n, int k, int[] ar)
        {
            return SumService.NumberOfSumPairs(k, ar);
        }
    }
}
