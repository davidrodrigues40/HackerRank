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
    }
}
