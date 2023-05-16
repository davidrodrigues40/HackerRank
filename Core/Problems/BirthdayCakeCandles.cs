using Core.Helpers;

namespace Core.Problems
{
    public class BirthdayCakeCandles : IProblem
    {
        public object Solve(object input)
        {
            var strValue = input.ToString();
            var strArray = strValue?.Split(' ');

            if (strArray == null || strArray.Length == 0) return 0;

            var arr = strArray.Select(int.Parse).ToArray();

            return arr.CountMax();
        }
    }
}
