using Core.Helpers;

namespace Core.Problems
{
    internal class SequenceEquation : IProblem
    {
        public object Solve(object input)
        {
            var list = input.ToIntList(' ');

            return PermutationEquation(list);
        }

        public static List<int> PermutationEquation(List<int> p)
        {
            return Enumerable.Range(1, p.Count).ToList().Select(x => p.IndexOf(p.IndexOf(x) + 1) + 1).ToList();
        }
    }
}
