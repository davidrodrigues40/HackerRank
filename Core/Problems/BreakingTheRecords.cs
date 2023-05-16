using Core.Helpers;
using Core.Services;

namespace Core.Problems
{
    public class BreakingTheRecords : IProblem
    {
        public object Solve(object input)
        {
            return BreakingRecords(input.ToIntArray_Int(' ')).ToOneLineString();
        }

        private static int[] BreakingRecords(int[] scores)
        {
            var (max, min) = RecordService.RecordsBroken(scores);
            return new[] { max, min };
        }
    }
}
