using Core.Helpers;

namespace Core.Problems
{
    public class PickingNumbers : IProblem
    {
        public object Solve(object input)
        {
            var p = input.ToIntList(',');

            return PickNumbers(p);
        }

        public static int PickNumbers(List<int> a)
        {
            var max = 0;
            for (int i = 0; i < a.Count; i++)
            {
                var currentIndex = i;
                var currentValue = a[i];
                var filtered = a.Where((int value, int index) => GetIndex(value, index, currentIndex, currentValue));

                max = Math.Max(filtered.Count(), max);
            }


            return max;
        }

        private static bool GetIndex(int value, int index, int currentIndex, int currentValue)
        {
            return (value == currentValue || value == currentValue + 1);
        }
    }
}