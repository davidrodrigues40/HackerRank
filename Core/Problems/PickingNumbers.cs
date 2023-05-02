using Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Problems
{
    public class PickingNumbers : IProblem
    {
        public void Solve(object input)
        {
            var p = input.ToIntList(',');

            Console.WriteLine(PickNumbers(p));
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