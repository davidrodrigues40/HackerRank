using Core.Helpers;
using Core.Services;

namespace Core.Problems
{
    public class GradingStudents : IProblem
    {
        public object Solve(object input)
        {
            var grades = input.ToIntList(' ');
            var output = new List<int>();

            grades.ForEach(grade => output.Add(RoundingService.Round(grade, 5, 2, 38)));

            return output;
        }
    }
}
