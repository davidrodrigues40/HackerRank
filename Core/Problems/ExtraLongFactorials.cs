using System.Numerics;

namespace Core.Problems
{
    public class ExtraLongFactorials : IProblem
    {
        public object Solve(object input)
        {
            var inputStr = input.ToString();
            if (inputStr == null) return 0;

            int n = int.Parse(inputStr);
            BigInteger output = n;
            do
            {
                n -= 1;
                output *= n;
            }
            while (n > 1);

            return output;
        }
    }
}
