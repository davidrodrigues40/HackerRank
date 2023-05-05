using Core.Helpers;

namespace Core.Problems
{
    internal class UtopianTree : IProblem
    {
        private readonly int _initialHeight = 1;
        public void Solve(object input)
        {
            var cycles = input.ToIntArray(' ');

            foreach (var cycle in cycles)
            {
                Console.WriteLine(DoWork(cycle));
            }
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
