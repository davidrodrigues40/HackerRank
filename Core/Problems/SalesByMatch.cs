using Core.Helpers;
using Newtonsoft.Json;

namespace Core.Problems
{
    public class SalesByMatch : IProblem
    {
        public object Solve(object input)
        {
            string[] p = input.ToStringList(' ');
            var ar = JsonConvert.DeserializeObject<int[]>(p[0]);
            var n = int.Parse(p[1]);

            if (ar == null) return 0;

            return DoWork(n, ar);
        }

        static int DoWork(int n, int[] ar)
        {
            var socks = ar.ToList();
            var pairs = 0;

            for (int i = 0; i < socks.Count; i++)
            {
                for (int x = i + 1; x < socks.Count; x++)
                {
                    if (socks[i] == socks[x])
                    {
                        pairs++;
                        socks.RemoveAt(x);
                        break;
                    }
                }
            }
            return pairs;
        }

    }
}
