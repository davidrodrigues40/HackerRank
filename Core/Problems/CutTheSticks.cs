using Core.Helpers;

namespace Core.Problems
{
    public class CutTheSticks : IProblem
    {
        private int[]? sticks = null;
        private readonly List<int> _output = new();
        public object Solve(object input)
        {
            sticks = input.ToIntArray_Int(' ');

            _output.Add(sticks.Count());

            SendToLumberYard();

            return _output;
        }

        private void SendToLumberYard()
        {
            if (sticks != null)
                while (sticks.Length > 1)
                {
                    PerformCut(out int shortest);
                    SubtractShortest(shortest);
                }
        }

        private void PerformCut(out int shortest)
        {
            var found = sticks.Min();
            List<int> cutSticks = sticks.Where(i => i == found).ToList();

            sticks = sticks.Where(s => !cutSticks.Contains(s)).ToArray();
            if (sticks != null && sticks.Length > 0) _output.Add(sticks.Length);

            shortest = found;
        }

        private void SubtractShortest(int cutPiece)
        {
            if (sticks != null)
                sticks.ToList().ForEach(i => i -= cutPiece);
        }
    }
}