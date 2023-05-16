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
                steps = PerformLongFunction(s, t, k);
            else if (s.Length == t.Length)
                steps = PerformEqualFunction(s, t, k);
            else
                steps = PerformShortFunction(s, t, k);

            return steps == k ? "Yes" : "No";
        }

        private static int PerformLongFunction(string s, string t, int k)
        {

            var intersection = s.Zip(t, (c1, c2) => c1 == c2).TakeWhile(b => b).Count();

            if (intersection == 0 && t.Length == s.Length && t.Length * 2 <= k) return k;

            var delete = s.Length - intersection;

            var additions = t.Length - intersection;

            var total = delete + additions;

            if (total > k) return total;

            if (((total + s.Length) % 2 == k % 2 || total % 2 == k % 2)) return k;

            return total;
        }

        private static int PerformShortFunction(string s, string t, int k)
        {
            var intersection = t.Zip(s, (c1, c2) => c1 == c2).TakeWhile(b => b).Count();

            if (intersection == 0 && t.Length == s.Length && t.Length * 2 <= k) return k;

            var delete = t.Length - intersection;

            var additions = s.Length - intersection;

            var total = delete + additions;

            if (total > k) return total;

            if ((total % 2 == k % 2 || total % 2 == k % 2)) return k;

            return total;
        }


        private static int PerformEqualFunction(string s, string t, int k)
        {
            if (s != t) return PerformLongFunction(t, s, k);

            if ((s.Length + t.Length) % 2 == k % 2) return k;

            return (s.Length * 2) + 1;
        }
    }
}
