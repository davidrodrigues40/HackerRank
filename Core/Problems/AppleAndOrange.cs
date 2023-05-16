using Core.Helpers;
using Core.Services;

namespace Core.Problems
{
    public class AppleAndOrange : IProblem
    {
        public object Solve(object input)
        {
            var strArray = input.ToStringList(' ');
            var s = int.Parse(strArray[0]);
            var t = int.Parse(strArray[1]);
            var a = int.Parse(strArray[2]);
            var b = int.Parse(strArray[3]);
            var apples = strArray[4].ToIntArray_Int(',');
            var oranges = strArray[5].ToIntArray_Int(',');

            return CountApplesAndOranges(s, t, a, b, apples, oranges);
        }

        private static int[] CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            return new int[] { CountApples(s, a, apples, t), CountOranges(t, b, oranges, s) };
        }

        private static int CountApples(int s, int a, int[] apples, int t)
        {
            return BoundryService.LeftSideInRange(s, t, a, apples);
        }

        private static int CountOranges(int t, int b, int[] oranges, int s)
        {
            return BoundryService.RightSideInRange(s, t, b, oranges);
        }
    }
}
