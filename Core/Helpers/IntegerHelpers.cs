using Newtonsoft.Json;
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

        public static int ToInt(this object input)
        {
            return int.Parse(input.ToString());
        }

        public static int[] ToIntArray(this object input, char separator)
        {
            var strArray = input.ToStringList(separator);

            return strArray.Select(int.Parse).ToArray();
        }

        public static int[] ToIntArray(this string input)
        {
            return JsonConvert.DeserializeObject<int[]>(input);
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

        public static bool Between(this int input, int lower, int upper)
        {
            return input >= lower && input <= upper;
        }

        public static int CountMax(this int[] input)
        {
            return input.Count(a => a == input.Max());
        }

        public static int CountMin(this int[] input)
        {
            return input.Count(a => a == input.Min());
        }

        public static int GreaterThanOrEqual(this int[] input, int max)
        {
            return input.Count(a => a >= max);
        }
        public static int LessThanOrEqual(this int[] input, int max)
        {
            return input.Count(a => a <= max);
        }

        public static string ToOneLineString(this int[] input)
        {
            var output = "";
            foreach (int item in input)
            {
                output += item + " ";
            }
            return output.Trim();
        }
    }
}
