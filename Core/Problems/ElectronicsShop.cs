using Core.Helpers;

namespace Core.Problems
{
    public class ElectronicsShop : IProblem
    {
        public object Solve(object input)
        {
            var p = input.ToStringArray(' ');
            var (arr1, arr2, integer) = p.ToIntArray_IntArray_Int();

            return GetMoneySpent(arr1, arr2, integer);
        }

        static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            keyboards.ToList().Sort();
            drives.ToList().Sort();

            var items = new List<int>();
            var output = -1;

            foreach (int keyboard in keyboards)
            {
                foreach (int usb in drives)
                {
                    var value = keyboard + usb;
                    if (value <= b) items.Add(keyboard + usb);
                }
            }

            output = items.Count > 0 ? items.Where(i => i <= b).ToList().Max() : -1;

            return output;
        }
    }
}
