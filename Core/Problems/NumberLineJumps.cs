using Core.Helpers;
using Core.Services;

namespace Core.Problems
{
    public class NumberLineJumps : IProblem
    {
        public object Solve(object input)
        {
            int[] strArray = input.ToIntArray_Int(' ');
            int x1 = strArray[0];
            int v1 = strArray[1];
            int x2 = strArray[2];
            int v2 = strArray[3];

            return KagarooService.Race(x1, v1, x2, v2);
        }
    }
}
