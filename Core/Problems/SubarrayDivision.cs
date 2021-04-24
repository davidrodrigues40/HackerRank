using Core.Helpers;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Problems
{
    public class SubarrayDivision : IProblem
    {
        public void Solve(object input)
        {
            string[] p = Splitter.ToStringArray(input, ' ');
            (int[] intArray, int int1, int int2) = Splitter.ToIntArray_Int_Int(p);

            //var s = JsonConvert.DeserializeObject<int[]>(p[0]);
            //var d = int.Parse(p[1]);
            //var m = int.Parse(p[2]);

            Console.WriteLine(birthday(intArray.ToList(), int1, int2));
        }

        static int birthday(List<int> s, int d, int m)
        {
            return SumService.CountSumWithLength(s.ToArray(), d, m);
        }
    }
}
