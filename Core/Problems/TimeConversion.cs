using Core.Services;
using System;

namespace Core.Problems
{
    public class TimeConversion : IProblem
    {
        public void Solve(object input)
        {
            var s = (string)input;
            var timeArr = s.Split(':');
            var (hour, min, sec) = TimeService.GetMilitaryTime(timeArr);

            Console.WriteLine($"{hour}:{min}:{sec}");
        }
    }
}
