using System;
using static Core.Helpers.Splitter;

namespace Core.Problems
{
    public class CountingValleys : IProblem
    {
        public void Solve(object input)
        {
            string[] p = input.ToStringArray(' ');
            (int steps, string path) = p.ToInt_String();

            Console.WriteLine(countingValleys(steps, path));
        }
        public static int countingValleys(int steps, string path)
        {
            int elevation = 0;
            int valleys = 0;

            char[] paths = path.ToCharArray();

            foreach (char step in paths)
            {
                int previousElevation = elevation;

                if (step == 'U')
                    elevation++;
                if (step == 'D')
                    elevation--;

                if (previousElevation >= 0 && elevation < 0)
                {
                    valleys++;
                }
            }
            return valleys;
        }

    }
}
