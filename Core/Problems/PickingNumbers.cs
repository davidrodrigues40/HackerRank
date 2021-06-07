using Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Problems
{
    public class PickingNumbers : IProblem
    {
        public void Solve(object input)
        {
            var p = input.ToIntList(' ');

            Console.WriteLine(pickingNumbers(p));
        }

        public static int pickingNumbers(List<int> a)
        {
            var list = new List<List<int>>();
            var curr = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (i == 0)
                    curr.Add(a[i]);
                else
                {
                    if (a[i] > a[i - 1])
                        movingUp(a[i], a[i - 1], curr, list);
                    else
                        movingDown(a[i], a[i - 1], curr, list);
                }
            }

            return list.Select(r => r.Count).Max();
        }

        private static void movingUp(int a, int b, List<int> curr, List<List<int>> list)
        {
            var beginNew = false;

            if (a - b > 1)
            {
                beginNew = true;
                list.Add(curr);
            }
            else
            {
                curr.Add(a);
            }

            if (beginNew)
            {
                curr = new List<int>() { a };
            }
        }

        private static void movingDown(int a, int b, List<int> curr, List<List<int>> list)
        {
            var beginNew = false;

            if (b - a > 1)
            {
                beginNew = true;
                list.Add(curr);
            }
            else
            {
                curr.Add(a);
            }

            if (beginNew)
            {
                curr = new List<int>() { a };
            }
        }
    }
}
