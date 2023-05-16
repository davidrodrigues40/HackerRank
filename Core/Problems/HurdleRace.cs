using Core.Helpers;

namespace Core.Problems
{
    internal class HurdleRace : IProblem
    {
        private const char _arraySplitter = ',';

        public object Solve(object input)

        {
            var arrays = input.ToStringArray(_arraySplitter);
            var character = int.Parse(arrays[0]);
            var heights = arrays[1].ToIntArray_Int(' ');

            return Race(character, heights);
        }

        public static int Race(int k, IEnumerable<int> height)
        {
            return Math.Max(height.Max() - k, 0);

        }
    }
}
