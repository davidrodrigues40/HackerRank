using System.Collections.Generic;

namespace Core.Helpers
{
    public static class Splitter
    {
        public static string[] ToStringArray(this object input, char splitter)
        {
            return input.ToStringList(splitter);
        }

        public static string[] ToStringArray(this char[] input)
        {
            List<string> arr = new List<string>();
            foreach (char item in input)
            {
                arr.Add(item.ToString());
            }
            return arr.ToArray();
        }

        public static (int[] intArray, int int1, int int2) ToIntArray_Int_Int(this string[] input)
        {
            var intArr = input[0].ToIntArray();
            var integer1 = int.Parse(input[1]);
            var integer2 = int.Parse(input[2]);

            return (intArr, integer1, integer2);
        }

        public static (int integer, string str) ToInt_String(this string[] input)
        {
            int integer = int.Parse(input[0]);
            string str = input[1];

            return (integer, str);
        }

        public static (int[] arr1, int[] arr2, int integer) ToIntArray_IntArray_Int(this string[] input)
        {
            var arr1 = input[0].ToIntArray();
            var arr2 = input[1].ToIntArray();
            var integer = input[2].ToInt();

            return (arr1, arr2, integer);
        }
    }
}
