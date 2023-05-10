using Core.Helpers;

namespace Core.Problems
{
    internal class SaveThePrisoner : IProblem
    {
        public void Solve(object input)
        {
            var lines = input.ToString().Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                var (n, m, s) = lines[i].ToInt_Int_Int(' ');
                var expected = Expected[i];
                var actual = DoWork(n, m, s);

                Console.WriteLine(actual);
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

        private static int[] Expected => $"3\n3\n1\n22815232\n12\n410053348\n10\n7\n6\n13\n5\n5378692\n20\n15\n4\n4\n5\n10\n4\n3\n1\n6\n2\n4\n1\n1\n2\n607\n3\n17\n3\n1\n2\n1\n6\n2\n15\n2\n27\n2\n1\n1\n7\n2\n2\n3\n1\n2\n2\n3\n3\n2\n3\n2\n1\n8\n18843\n1\n2\n9\n13\n6\n1\n1\n1\n1\n7\n3\n2\n2\n9\n2\n7\n14\n3\n9\n3\n6\n7\n3\n3\n3\n1\n1\n1\n5\n2\n5\n6\n1\n3\n4\n11\n3\n5\n1\n38321\n1460445\n10\n1".Split('\n').Select(s => int.Parse(s)).ToArray();
    }
}