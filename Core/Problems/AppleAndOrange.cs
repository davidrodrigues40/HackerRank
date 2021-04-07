using Core.Helpers;
using Core.Services;
using System;

namespace Core.Problems
{
    public class AppleAndOrange : IWorker
    {
        public void DoWork(object input)
        {
            var strArray = input.ToStringList(' ');
            var s = int.Parse(strArray[0]);
            var t = int.Parse(strArray[1]);
            var a = int.Parse(strArray[2]);
            var b = int.Parse(strArray[3]);
            var apples = strArray[4].ToIntArray(',');
            var oranges = strArray[5].ToIntArray(',');

            CountApplesAndOranges(s, t, a, b, apples, oranges);
        }

        private void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            CountApples(s, a, apples, t);
            CountOranges(t, b, oranges, s);
        }

        private void CountApples(int s, int a, int[] apples, int t)
        {
            Console.WriteLine(BoundryService.LeftSideInRange(s, t, a, apples));
        }

        private void CountOranges(int t, int b, int[] oranges, int s)
        {
            Console.WriteLine(BoundryService.RightSideInRange(s, t, b, oranges));
        }
    }
}
