using Core.Helpers;
using System;
using System.Globalization;
using System.Linq;

namespace Core.Problems
{
    public class DayOfTheProgrammer : IProblem
    {
        public void Solve(object input)
        {
            var year = input.ToInt();
            Console.WriteLine(dayOfProgrammer(year));
        }

        static string dayOfProgrammer(int year)
        {
            return calculateDayOfYear(year);
        }

        static string calculateDayOfYear(int year)
        {
            var offYears1700 = new[] { 1711, 1737, 1741, 1758, 1783 };
            if (year <= 1917)
            {
                var mod = 1;
                if (offYears1700.Contains(year))
                {
                    mod = -1;
                }
                if (year == 1800 || year == 1836)
                {
                    mod--;
                }
                else if (year % 4 == 0 && year != 1916 && year != 1900)
                {
                    if (year == 1772)
                        mod -= 2;
                    else if (year == 1700)
                        mod = -1;
                    else if (year != 1908)
                        mod = 0;
                }

                return CalculateJulian(year, 256 - mod);
            }

            if (year == 1918)
                return CalculateJulian(year, 256 + 12);

            return CalculateGregorian(year, 256);
        }

        static string CalculateJulian(int year, int daysToAdd)
        {
            var calendar = new JulianCalendar();
            var d = new DateTime(year, 1, 1, calendar);
            var d2 = d.AddDays(daysToAdd - 13);

            return FormatDate(d2);
        }

        static string CalculateGregorian(int year, int daysToAdd)
        {
            var calendar = new GregorianCalendar();
            var d = new DateTime(year, 1, 1, calendar).AddDays(daysToAdd - 1);

            return FormatDate(d);
        }

        static string FormatDate(DateTime d)
        {
            return d.ToString("dd.MM.yyyy");
        }
    }
}
