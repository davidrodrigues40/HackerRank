using Core.Helpers;
using Core.Services;
using System;
using System.Collections.Generic;

namespace Core.Problems
{
    public class GradingStudents : IProblem
    {
        public void Solve(object input)
        {
            var grades = input.ToIntList(' ');
            var output = new List<int>();

            grades.ForEach(grade => output.Add(RoundingService.Round(grade, 5, 2, 38)));

            output.ForEach(grade => Console.WriteLine(grade));
        }
    }
}
