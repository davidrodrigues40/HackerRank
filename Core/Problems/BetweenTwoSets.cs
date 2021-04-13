using Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Core.Problems
{
    public class BetweenTwoSets : IProblem
    {
        public void Solve(object input)
        {
            var strValue = input.ToString().Split(' ');
            List<int> a = JsonConvert.DeserializeObject<List<int>>(strValue[0]);
            List<int> b = JsonConvert.DeserializeObject<List<int>>(strValue[1]);

            Console.WriteLine(getTotalX(a, b));
        }

        public static int getTotalX(List<int> a, List<int> b)
        {
            // sort arrays
            a.Sort();
            b.Sort();

            var lcm = CommonMultiplierService.lowestCommonMultipliers(a.ToArray(), b.ToArray());
            var gcd = CommonMultiplierService.greatestCommonDenominators(b.ToArray(), lcm);

            return gcd.Length;
        }
    }
}
