using Core.Helpers;
using System;

namespace Core.Problems
{
    public class FindDigits : IWorker
    {
        public void DoWork(object input)
        {

            int n = int.Parse((string)input);
            int output = 0;

            var digits = n.GetDigits();

            foreach (int c in digits)
            {
                if (c != 0 && n % c == 0)
                    output++;
            }
            Console.WriteLine(output);
        }
    }
}
