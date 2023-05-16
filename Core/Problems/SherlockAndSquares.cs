using Core.Helpers;

namespace Core.Problems
{
    internal class SherlockAndSquares : IProblem
    {
        public object Solve(object input)
        {
            (int a, int b) = input.ToInt_Int(' ');

            return DoWork(a, b);
        }

        private static int DoWork(int a, int b)
        {
            var lower = Math.Ceiling(Math.Sqrt(a));
            var upper = Math.Ceiling(Math.Sqrt(b));

            return (int)(upper - lower);

        }
    }
}
