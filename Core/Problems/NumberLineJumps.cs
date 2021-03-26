using Core.Helpers;
using System;

namespace Core.Problems
{
    public class NumberLineJumps : IWorker
    {
        public void DoWork(object input)
        {
            int[] strArray = input.ToIntArray(' ');
            int x1 = strArray[0];
            int v1 = strArray[1];
            int x2 = strArray[2];
            int v2 = strArray[3];

            Console.WriteLine(Kangaroo(x1, v1, x2, v2));
        }

        static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x2 > x1 && v2 > v1) return "NO";
            if (x1 > x2 && v1 > v2) return "NO";
            if (v1 == v2 && x1 != x2) return "NO";

            var xJump = Jump(x1, v1);
            var yJump = Jump(x2, v2);

            if (xJump == yJump) return "YES";

            return Kangaroo(xJump, v1, yJump, v2);
        }

        static int Jump(int x, int v)
        {
            return x + v;
        }
    }
}
