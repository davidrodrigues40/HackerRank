using Core.Helpers;

namespace Core.Problems
{
    public class AppendAndDelete : IProblem
    {
        public object Solve(object input)
        {
            var (s, t, k) = input.ToString_String_Int(' ');

            return GenerateOutput(s, t, k);

        }

        private static string GenerateOutput(string s, string t, int k)
        {
            var steps = 0;

            if (s.Length > t.Length)
                steps = PerformFunction(s, t, k);
            else
                steps = PerformEqualFunction(s, t, k);

            return steps == k ? "Yes" : "No";
        }

        private static int PerformFunction(string longest, string shortest, int k)
        {
            if (longest.StartsWith(shortest)) return StartsWith(longest, shortest, k);

            var intersection = longest.Intersect(shortest);

            var delete = longest.Length - intersection.Count();

            var additions = shortest.Length - intersection.Count();

            var total = delete + additions;

            return (total % 2 == k % 2 ? k : total);
        }


        private static int PerformEqualFunction(string s, string t, int k)
        {
            if (s.Length != t.Length || s != t) return PerformFunction(t, s, k);

            if ((s.Length + t.Length) % 2 == k % 2) return k;

            return (s.Length * 2) + 1;
        }

        private static int StartsWith(string longest, string shortest, int k)
        {
            var steps = longest.Length - shortest.Length;
            if (steps % 2 == k % 2) return k;
            return steps;
        }
    }
}
