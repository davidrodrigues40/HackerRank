using System.Linq;

namespace Core.Services
{
    public static class SumService
    {
        public static int MaxSum(int[] arr)
        {
            var lowestNum = arr.ToList().Min();
            var list = arr.ToList();
            list.Remove(lowestNum);

            return list.Sum();
        }

        public static int MinSum(int[] arr)
        {
            var highestNum = arr.ToList().Max();
            var list = arr.ToList();
            list.Remove(highestNum);

            return list.Sum();
        }

        public static int CountSumWithLength(int[] arr, int sum, int length)
        {
            var count = 0;

            for (int i = 0; i <= (arr.Length - length); i++)
            {
                int[] innerArray = new int[length];

                for (int x = 0; x < length; x++)
                {
                    innerArray.SetValue(arr[i + x], x);
                }
                if (innerArray.Sum() == sum)
                    count++;
            }

            return count;
        }

        public static int NumberOfSumPairs(int mod, int[] input)
        {
            var count = 0;
            var n = input.Length;
            for (int i = 0; i < n; i++)
            {
                var first = input[i];
                for (int x = i + 1; x < n; x++)
                {
                    var second = input[x];

                    if ((first + second) % mod == 0)
                        count++;
                }
            }

            return count;
        }
    }
}
