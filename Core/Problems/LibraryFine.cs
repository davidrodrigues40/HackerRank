using Core.Helpers;
using System.Dynamic;

namespace Core.Problems
{
    internal class LibraryFine : IProblem
    {
        public object Solve(object input)
        {
            (int[] array1, int[] array2) = input.ToIntArray_IntArray(',', ' ');
            dynamic returnedDate = new ExpandoObject();
            returnedDate.day = array1[0];
            returnedDate.month = array1[1];
            returnedDate.year = array1[2];

            dynamic dueDate = new ExpandoObject();
            dueDate.day = array2[0];
            dueDate.month = array2[1];
            dueDate.year = array2[2];


            return DoWork(returnedDate.day, returnedDate.month, returnedDate.year, dueDate.day, dueDate.month, dueDate.year);
        }

        private static int DoWork(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            var returnedDate = new DateTime(y1, m1, d1);
            var dueDate = new DateTime(y2, m2, d2);

            return CalculateFine(returnedDate, dueDate);
        }

        private static int CalculateFine(DateTime returnedDate, DateTime dueDate)
        {
            if (returnedDate <= dueDate) return 0;

            if (returnedDate.Month == dueDate.Month && returnedDate.Year == dueDate.Year)
                return 15 * (returnedDate.Day - dueDate.Day);

            if (returnedDate.Year == dueDate.Year)
                return 500 * (returnedDate.Month - dueDate.Month);

            return 10000;
        }
    }
}
