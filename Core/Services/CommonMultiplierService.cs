using System.Collections.Generic;
using System.Linq;

namespace Core.Services
{
    public static class CommonMultiplierService
    {
        public static int[] lowestCommonMultipliers(int[] a, int[] b)
        {
            var results = new int[] { };
            Dictionary<int, int> multipliers = new Dictionary<int, int>();

            var upper = b.Min();

            if (a.Length == 1)
            {
                if (a[0] == 1) return lowestCommonMultipliers(b, a[0]);
                return a;
            }

            foreach (var item in a)
            {
                for (int i = 1; i < upper; i++)
                {
                    var mult = item * i;
                    if (mult > upper)
                        break;

                    if (multipliers.ContainsKey(mult))
                        multipliers[mult]++;
                    else
                        multipliers.Add(mult, 1);
                }

            }

            // now we have the list of all multiplications for list a
            return multipliers.Where(aList => aList.Value == a.Length).Select(bList => { return bList.Key; }).ToArray();
        }

        public static int[] greatestCommonDenominators(int[] b, int[] lcm)
        {
            var output = new List<int>();

            foreach (int i in lcm)
            {
                var count = 0;
                foreach (int item in b)
                {
                    if ((item % i) != 0) break;
                    count++;
                }
                if (count == b.Length)
                    output.Add(i);
            }

            return output.ToArray();
        }

        private static int[] lowestCommonMultipliers(int[] b, int lcm)
        {
            var output = new List<int>();
            var min = b.Min();

            while (min > 0)
                while (min > 0)
                {
                    output.Add(min * lcm);
                    min--;
                }

            return output.ToArray();
        }
    }
}
