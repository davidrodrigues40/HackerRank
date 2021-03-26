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

        public static int[] ToIntArray(this object input, char separator)
        {
            var strArray = input.ToStringList(separator);

            return strArray.Select(int.Parse).ToArray();
        }

        public static List<int> ToIntList(this object input, char separator)
        {
            var strArray = input.ToStringList(separator);

            return strArray.Select(int.Parse).ToList();
        }

        public static string[] ToStringList(this object input, char separator)
        {
            return input.ToString().Split(separator);
        }

        public static bool Between(this int value, int lower, int upper)
        {
            return value >= lower && value <= upper;
        }
    }
}
