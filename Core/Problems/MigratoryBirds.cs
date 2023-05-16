using Core.Helpers;
using Core.Services;

namespace Core.Problems
{
    public class MigratoryBirds : IProblem
    {
        public object Solve(object input)
        {
            var list = input.ToIntList(' ');
            return DoWork(list);
        }
        /// <summary>
        /// Given an array of bird sightings where every element represents a bird type id, determine the id of the most frequently sighted type. 
        /// If more than 1 type has been spotted that maximum amount, return the smallest of their ids.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int DoWork(List<int> arr)
        {
            var birds = CountInstanceService.CountIntegers(arr.ToArray());

            Dictionary<int, int> mostSpotted = birds.Where(b => b.Value == birds.Values.Max()).ToDictionary(x => x.Key, y => y.Value);

            return mostSpotted.Keys.Min();
        }
    }
}
