using Core.Helpers;
using System;
using System.Collections.Generic;

namespace Core.Problems
{
    public class GradingStudents : IWorker
    {
        public void DoWork(object input)
        {
            var grades = input.ToIntList(' ');
            var output = new List<int>();

            grades.ForEach(grade => output.Add(RoundGrade(grade)));

            output.ForEach(grade => Console.WriteLine(grade));
        }

        public int RoundGrade(int grade)
        {
            var mod = grade % 5;
            Console.WriteLine(mod);
            if (grade < 38 || mod <= 2)
                return grade;

            return grade + (5 - mod);
        }
    }
}
