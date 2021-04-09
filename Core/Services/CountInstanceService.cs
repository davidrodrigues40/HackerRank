using System.Collections.Generic;

namespace Core.Services
{
    public static class CountInstanceService
    {
        public static Dictionary<int, int> CountIntegers(int[] input)
        {
            var output = new Dictionary<int, int>();
            foreach (int item in input)
            {
                if (output.ContainsKey(item))
                    output[item]++;
                else
                    output.Add(item, 1);
            }

            return output;
        }
    }
}
