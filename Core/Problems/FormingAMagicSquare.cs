using Core.Helpers;

namespace Core.Problems
{
    public class FormingAMagicSquare : IProblem
    {
        private static List<int> baseNumber = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static List<int> oneToNine = new List<int>();
        private static List<int> duplicates = new List<int>();
        private static List<int> rowsWithDups = new List<int>();

        public object Solve(object input)
        {
            var p = input.ToStringArray(' ');

            return DoWork(p.ToListOfIntList());
        }

        public static int DoWork(List<List<int>> s)
        {
            int[] costs = { 0, 0, 0, 0, 0, 0, 0, 0 };
            int[][] t = {
                new [] {4,9,2,3,5,7,8,1,6},
                new [] {4,3,8,9,5,1,2,7,6},
                new [] {2,9,4,7,5,3,6,1,8},
                new [] {2,7,6,9,5,1,4,3,8},
                new [] {8,1,6,3,5,7,4,9,2},
                new [] {8,3,4,1,5,9,6,7,2},
                new [] {6,7,2,1,5,9,8,3,4},
                new [] {6,1,8,7,5,3,2,9,4}
            };

            for (int i = 0; i < 8; i++)
            {
                costs[i] = Math.Abs(t[i][0] - s[0][0]) + Math.Abs(t[i][1] - s[0][1]) + Math.Abs(t[i][2] - s[0][2]);
                costs[i] = costs[i] + Math.Abs(t[i][3] - s[1][0]) + Math.Abs(t[i][4] - s[1][1]) + Math.Abs(t[i][5] - s[1][2]);
                costs[i] = costs[i] + Math.Abs(t[i][6] - s[2][0]) + Math.Abs(t[i][7] - s[2][1]) + Math.Abs(t[i][8] - s[2][2]);
            }
            Array.Sort(costs);

            return costs[0];
        }
    }
}
