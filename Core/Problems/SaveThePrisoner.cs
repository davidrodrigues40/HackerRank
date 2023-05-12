using Core.Helpers;

namespace Core.Problems
{
    internal class SaveThePrisoner : IProblem
    {
        public void Solve(object input)
        {
            string[]? lines = input.ToString()?.Split('\n');
            if (lines != null)
                for (int i = 0; i < lines.Length; i++)
                {
                    var (n, m, s) = lines[i].ToInt_Int_Int(' ');

                    Console.WriteLine(DoWork(n, m, s));
                }
        }

        /// <summary>
        /// Does the work.
        /// </summary>
        /// <param name="n">The number of prisoners</param>
        /// <param name="m">The number of candy</param>
        /// <param name="s">The staring seat to get the candy</param>
        /// <returns>The prisoner to get the last piece of candy</returns>
        private static int DoWork(int n, int m, int s)
        {
            if (n == 1) return n;

            int endUnit = m + s;
            int remainder = endUnit % n;

            int output = n - 1 + remainder;

            if (output > n)
            {
                output -= n;
            }

            return output;
        }
    }
}