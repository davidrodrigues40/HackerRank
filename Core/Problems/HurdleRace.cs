using Core.Helpers;

namespace Core.Problems
{
    internal class HurdleRace : IProblem
    {
        private static int _currentHeight = 0;
        private const char _arraySplitter = ',';

        public void Solve(object input)
        {
            var arrays = input.ToStringArray(_arraySplitter);
            var character = int.Parse(arrays[0]);
            var heights = arrays[1].ToIntArray(' ');

            Console.WriteLine(hurdleRace(character, heights));
        }

        public static int hurdleRace(int k, IEnumerable<int> height)
        {
            return Math.Max(height.Max() - k, 0);

        }
    }
}
