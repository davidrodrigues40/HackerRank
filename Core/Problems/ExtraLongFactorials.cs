using System;
using System.Numerics;

namespace Core.Problems
{
    public class ExtraLongFactorials : IProblem
    {
        public void Solve(object input)
        {
            int n = int.Parse(input.ToString());
            BigInteger output = n;
            do
            {
                n -= 1;
                output *= n;
            }
            while (n > 1);
            Console.WriteLine(output);
        }
    }
}
