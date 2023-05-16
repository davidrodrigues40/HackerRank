using Core.Helpers;

namespace Core.Problems
{
    internal class AngryProfessor : IProblem
    {
        public object Solve(object input)
        {
            var (k, a) = Splitter.ToInt_IntArray(input, ',', ' ');
            // k = threshold
            // a = arrival time

            return DoWork(k, a.ToList());
        }

        private static string DoWork(int k, List<int> a)
        {
            return a.FindAll(v => v <= 0).Count < k ? "YES" : "NO";
        }
    }
}
