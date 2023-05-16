using Core.Services;
using Newtonsoft.Json;

namespace Core.Problems
{
    public class BetweenTwoSets : IProblem
    {
        public object Solve(object input)
        {
            var strValue = input.ToString();
            var strArray = strValue?.Split(' ');
            if (strArray == null) return string.Empty;

            if (strArray.Length < 2) return string.Empty;

            List<int>? a = JsonConvert.DeserializeObject<List<int>>(strArray[0]);
            List<int>? b = JsonConvert.DeserializeObject<List<int>>(strArray[1]);

            if (a == null || b == null) return string.Empty;

            return GetTotalX(a, b);
        }

        public static int GetTotalX(List<int> a, List<int> b)
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
