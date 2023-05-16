using Core.Helpers;
using Core.Services;

namespace Core.Problems
{
    public class SubarrayDivision : IProblem
    {
        public object Solve(object input)
        {
            string[] p = Splitter.ToStringArray(input, ' ');
            (int[] intArray, int int1, int int2) = Splitter.ToIntArray_Int_Int(p);

            return DoWork(intArray.ToList(), int1, int2);
        }

        static int DoWork(List<int> s, int d, int m)
        {
            return SumService.CountSumWithLength(s.ToArray(), d, m);
        }
    }
}
