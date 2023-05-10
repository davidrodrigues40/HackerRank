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

        public static (int integer1, int integer2, int integer3) ToInt_Int_Int(this object input, char separator)
        {
            return ToInt_Int_Int(input.ToStringArray(separator));
        }

        public static (int integer1, int integer2, int integer3) ToInt_Int_Int(this string[] input)
        {
            return (input[0].ToInt(), input[1].ToInt(), input[2].ToInt());
        }

        public static List<int[]> ToListOfIntArrays(this string[] input)
        {
            var output = new List<int[]>();

            foreach (string item in input)
            {
                output.Add(item.ToIntArray());
            }

            return output;
        }

        public static List<List<int>> ToListOfIntList(this string[] input)
        {
            var output = new List<List<int>>();

            foreach (string item in input)
            {
                output.Add(item.ToIntArray().ToList());
            }

            return output;
        }

        public static (int[] arr1, int[] arr2, int integer) ToIntArray_IntArray_Int(this string[] input)
        {
            var arr1 = input[0].ToIntArray();
            var arr2 = input[1].ToIntArray();
            var integer = input[2].ToInt();

            return (arr1, arr2, integer);
        }

        public static (int[], string word) ToIntArray_String(this string[] input)
        {
            var arr1 = input[0].ToIntArray(' ');
            var word = input[1].ToString();

            return (arr1, word);
        }

        public static (int, int[]) ToInt_IntArray(this object input, char arraySplitter, char intSplitter)
        {
            var arrs = input.ToStringArray(arraySplitter);
            var intArray = arrs[1].ToIntArray(intSplitter);
            var integer = arrs[0].ToInt();

            return (integer, intArray);
        }
    }
}
