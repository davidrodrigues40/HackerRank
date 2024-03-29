﻿using Core.Helpers;

namespace Core.Problems
{
    internal class BeautifulDaysAtTheMovies : IProblem
    {
        public object Solve(object input)
        {
            var ints = input.ToIntArray_Int(',');

            return DoWork(ints[0], ints[1], ints[2]);
        }

        private static int DoWork(int i, int j, int k)
        {
            var beautifulDays = 0;
            for (var x = i; x <= j; x++)
            {
                var inverseArr = x.ToString().ToCharArray().Reverse().ToArray();
                decimal inverse = decimal.Parse(string.Join("", inverseArr));
                decimal results = (Math.Max(x, inverse) - Math.Min(x, inverse)) / k;
                if (results % 1 == 0) beautifulDays++;
            }

            return beautifulDays;
        }
    }
}
