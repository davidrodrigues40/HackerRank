using Core.Services;

namespace Core.Problems
{
    public class Staircase : IProblem
    {
        private const string _character = "#";
        public object Solve(object s)
        {
            var size = int.Parse((string)s);
            return StepService.BuildSteps(size, _character);
        }
    }
}
