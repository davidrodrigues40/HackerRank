using Newtonsoft.Json;

namespace Core.Helpers
{
    public static class IntegerHelpers
    {
        public static List<int> GetDigits(this int input)
        {
            List<int> list = new();

            string stringDigits = input.ToString();
            foreach (char c in stringDigits)
            {
                list.Add(int.Parse(c.ToString()));
            }

            return list;
        }

        public static int ToInt(this object input)
        {
            _ = int.TryParse(input.ToString(), out var output);

            return output;
        }

        public static int[] ToIntArray_Int(this object input, char separator)
        {
            var strArray = input.ToStringList(separator);

            return strArray.Select(int.Parse).ToArray();
        }

        public static int[] ToIntArray(this string input)
        {
            var output = JsonConvert.DeserializeObject<int[]>(input);
            if (output != null)
                return output;

            return Array.Empty<int>();
        }

        public static List<int> ToIntList(this object input, char separator)
        {
            var strArray = input.ToStringList(separator);

            return strArray.Select(int.Parse).ToList();
        }

        public static List<int> ToIntList(this object input)
        {
            var output = new List<int>();
            var str = input.ToString();
            if (str != null)
                output = JsonConvert.DeserializeObject<List<int>>(str);

            return output ?? new List<int>();
        }

        public static string[] ToStringList(this object input, char separator)
        {
            var output = input.ToString();
            if (output != null)
                return output.Split(separator);

            return Array.Empty<string>();
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

        public static int Sum(this List<int> input)
        {
            var output = 0;
            foreach (var number in input)
            {
                output += number;
            }

            return output;
        }
    }
}