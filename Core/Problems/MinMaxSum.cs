using Core.Services;

namespace Core.Problems
{
    public class MinMaxSum : IProblem
    {
        public object Solve(object a)
        {
            var str = a.ToString();
            var strArray = str?.Split(' ');

            if (strArray == null) return string.Empty;

            int[] arr = strArray.Select<string, int>(int.Parse).ToArray();


            return $"{SumService.MinSum(arr)} {SumService.MaxSum(arr)}";
        }
    }
}
