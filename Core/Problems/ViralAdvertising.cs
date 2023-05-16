using Core.Helpers;

namespace Core.Problems
{
    internal class ViralAdvertising : IProblem
    {
        public object Solve(object input)
        {
            var days = input.ToInt();
            return DoWork(days);
        }

        public int DoWork(int n)
        {
            decimal cumulative = 0;
            decimal shared = 5;
            while (n > 0)
            {
                decimal liked = Math.Floor((decimal)shared / 2);
                cumulative += liked;
                shared = liked * 3;
                n--;
            }

            return (int)cumulative;
        }
    }
}
