using System;

namespace Core.Problems
{
    public class FindDigits : IWorker
    {
        public void DoWork(object input)
        {
            var helper = new Helper();

            int n = int.Parse((string)input);
            int output = 0;

            var digits = helper.GetDigits(n);

            foreach(int c in digits)
            {
                if (c != 0 && n % c == 0)
                    output++;
            }
            Console.WriteLine(output);
        }
    }
}
