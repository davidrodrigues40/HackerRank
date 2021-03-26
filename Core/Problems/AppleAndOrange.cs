using Core.Helpers;
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
            var count = 0;
            if (a < s)
            {
                foreach (int apple in apples)
                {
                    if ((a + apple).Between(s, t)) count++;
                }
            }
            Console.WriteLine(count);
        }

        private void CountOranges(int t, int b, int[] oranges, int s)
        {
            var count = 0;
            if (b > t)
            {
                foreach (int orange in oranges)
                {
                    if ((b + orange).Between(s, t)) count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
