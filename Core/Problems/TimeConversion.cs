using Core.Services;

namespace Core.Problems
{
    public class TimeConversion : IProblem
    {
        public object Solve(object input)
        {
            var s = (string)input;
            var timeArr = s.Split(':');
            var (hour, min, sec) = TimeService.GetMilitaryTime(timeArr);

            return $"{hour}:{min}:{sec}";
        }
    }
}
