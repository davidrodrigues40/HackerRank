using Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Problems
{
    public class FormingAMagicSquare : IProblem
    {
        private static List<int> oneToNine = new List<int>();
        private static List<int> duplicates = new List<int>();
        private static List<int> rowsWithDups = new List<int>();

        public void Solve(object input)
        {
            var p = input.ToStringArray(' ');

            Console.WriteLine(formingMagicSquare(p.ToListOfIntList()));
        }
        public static int formingMagicSquare(List<List<int>> s)
        {
            var row1 = s[0];
            var row2 = s[1];
            var row3 = s[2];

            var col1 = new List<int>() { row1[0], row2[0], row3[0] };
            var col2 = new List<int>() { row1[1], row2[1], row3[1] };
            var col3 = new List<int>() { row1[2], row2[2], row3[2] };

            findDuplicates(s);

            // find rows with dupes, do any add to 15;
            for (int i = rowsWithDups.Count - 1; i >= 0; i--)
            {
                if (s[rowsWithDups[i]].Sum() == 15)
                    rowsWithDups.RemoveAt(i);
            }

            return rowsWithDups.Count;

        }

        static void findDuplicates(List<List<int>> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                foreach (var number in input[i])
                {
                    if (!oneToNine.Contains(number))
                        oneToNine.Add(number);
                    else
                        duplicates.Add(number);
                }
            }

            foreach (var duplicate in duplicates)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i].Contains(duplicate))
                        rowsWithDups.Add(i);
                }
            }
        }
    }
}
