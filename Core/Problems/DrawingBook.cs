using Core.Helpers;

namespace Core.Problems
{
    public class DrawingBook : IProblem
    {
        public object Solve(object input)
        {
            string[] p = input.ToStringList(' ');
            int pages = p[0].ToInt();
            int turnTo = p[1].ToInt();

            return PageCount(pages, turnTo);
        }

        static int PageCount(int n, int p)
        {
            if (n / 2 >= p)
                return TurnFromFront(p);

            return TurnFromEnd(n, p);
        }

        static int TurnFromEnd(int n, int p)
        {
            int turned = 0;
            int mod = n % 2 == 0 ? 1 : 0;
            if (p == n) return turned;

            for (int i = n + mod; i >= p;)
            {
                if (i == p || i - 1 == p)
                    break;
                i -= 2;
                turned++;
            }

            return turned;
        }

        static int TurnFromFront(int p)
        {
            int turned = 0;
            for (int i = 2; i <= p;)
            {
                turned++;
                if (i == p || i + 1 == p)
                    break;

                i += 2;
            }

            return turned;
        }

    }
}
