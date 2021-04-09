using Core.Helpers;
using Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Problems
{
    public class SubarrayDivision : IWorker
    {
        public void DoWork(object input)
        {
            string[] p = input.ToStringList(' ');
            var s = JsonConvert.DeserializeObject<int[]>(p[0]);
            var d = int.Parse(p[1]);
            var m = int.Parse(p[2]);

            Console.WriteLine(birthday(s.ToList(), d, m));
        }

        static int birthday(List<int> s, int d, int m)
        {
            return SumService.CountSumWithLength(s.ToArray(), d, m);
        }
    }
}
