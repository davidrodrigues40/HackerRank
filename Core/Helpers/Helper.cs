using System.Collections.Generic;
using System.Linq;

namespace Core.Helpers
{
    public static class IntegerHelpers
    {
        public static List<int> GetDigits(this int input)
        {
            List<int> list = new List<int>();

            string stringDigits = input.ToString();
            foreach (char c in stringDigits)
            {
                list.Add(int.Parse(c.ToString()));
            }
            return list;
        }

        public static int[] GetIntArray(this object input, char separator)
        {
            var strArray = input.ToString().Split(' ');

            return strArray.Select(int.Parse).ToArray();
        }
    }
}
