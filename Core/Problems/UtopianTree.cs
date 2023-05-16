using Core.Helpers;

namespace Core.Problems
{
    internal class UtopianTree : IProblem
    {
        public object Solve(object input)
        {
            var cycles = input.ToIntArray_Int(' ');
            var output = new List<int>();

            foreach (var cycle in cycles)
            {
                output.Add(DoWork(cycle));
            }

            return output;
        }

        private static int DoWork(int n)
        {
            int height = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    height += 1;
                else
                    height *= 2;
            }

            return height;
        }
    }
}
