using System;

namespace Core.Problems
{
    public class AppendAndDelete : IWorker
    {
        public void DoWork(object input)
        {
            var n = (string)input;
            var arr = n.Split(' ');
            var s = arr[0];
            var t = arr[1];
            var k = int.Parse(arr[2]);

            Console.WriteLine(GenerateOutput(s, t, k));

        }

        private string GenerateOutput(string s, string t, int k)
        {
            int count = 0;
            int a = s.Length - t.Length;
            var arr = new[] { s, t };

            if (s.Length > t.Length)
            {
                count += PerformFunction(s, t);
            }
            else if (t.Length > s.Length)
            {
                count += PerformFunction(t, s);
            }
            else
            {
                count = PerformFunction(s, t, k);
            }

            if ((k - count) % 2 == 0)
                count = k;

            return k == count ? "Yes" : "No";
            //return count == k ? "Yes" : "No";
        }

        private int PerformFunction(string s, string t, int k)
        {
            var count = s.Length * 2;
            if (count % 2 == 0)
            {
                count = k;
            }

            return count;
        }

        private int PerformFunction(string longest, string shortest)
        {
            int count = 0;
            for (var x = longest.Length - 1; x >= 0; x--)
            {
                count++;
                longest = longest.Substring(0, x);
                if (shortest.Length >= x && longest == shortest.Substring(0, x))
                {
                    count += Rebuild(longest, shortest);
                    break;
                }
            }
            return count;
        }

        private int Rebuild(string s, string t)
        {
            int count = 0;

            var appendix = t.Substring(s.Length);
            // append
            count += appendix.Length;

            return count;
        }
    }
}
