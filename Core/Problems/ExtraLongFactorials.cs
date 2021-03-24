using System;
using System.Numerics;

namespace Core.Problems
{
    public class ExtraLongFactorials : IWorker
    {
        public void DoWork(object input)
        {
            int n = int.Parse(input.ToString());
            BigInteger output = n;
            do
            {
                n -= 1;
                if (n > 0)
                {
                    output *= (n);
                }
            }
            while (n > 1);
            Console.WriteLine(output);
        }
    }
}
