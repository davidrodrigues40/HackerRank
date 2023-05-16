using Core.Helpers;

namespace Core.Problems
{
    public class FindDigits : IProblem
    {
        public object Solve(object input)
        {

            int n = int.Parse((string)input);
            int output = 0;

            var digits = n.GetDigits();

            foreach (int c in digits)
            {
                if (c != 0 && n % c == 0)
                    output++;
            }

            return output;
        }
    }
}
