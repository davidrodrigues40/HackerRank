using Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Problems
{
    public class CutTheSticks : IWorker
    {
        public int[] sticks;
        public List<int> output = new List<int>();
        public void DoWork(object input)
        {
            sticks = input.ToIntArray(' ');

            output.Add(sticks.Count());

            SendToLumberYard();

            ShowOutput();
        }

        private void SendToLumberYard()
        {
            while (sticks.Length > 1)
            {
                PerformCut(out int shortest);
                SubtractShortest(shortest);
            }
        }

        private void PerformCut(out int shortest)
        {
            var found = sticks.Min();
            List<int> cutSticks = sticks.Where(i => i == found).ToList();

            sticks = sticks.Where(s => !cutSticks.Contains(s)).ToArray();
            if (sticks.Count() > 0) output.Add(sticks.Count());

            shortest = found;
        }

        private void SubtractShortest(int cutPiece)
        {
            sticks.ToList().ForEach(i => i -= cutPiece);
        }

        private void ShowOutput()
        {
            foreach (int item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}