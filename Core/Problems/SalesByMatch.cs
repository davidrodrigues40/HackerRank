using Core.Helpers;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Core.Problems
{
    public class SalesByMatch : IProblem
    {
        public void Solve(object input)
        {
            string[] p = input.ToStringList(' ');
            var ar = JsonConvert.DeserializeObject<int[]>(p[0]);
            var n = int.Parse(p[1]);

            Console.WriteLine(sockMerchant(n, ar));
        }

        static int sockMerchant(int n, int[] ar)
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
