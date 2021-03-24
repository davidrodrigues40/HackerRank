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
            var strArray = input.ToString().Split(' ');

            sticks = strArray.Select<string, int>(int.Parse).ToArray();

            output.Add(sticks.Count());

            SendToLumberYard();

            ShowOutput();
        }

        private void SendToLumberYard()
        {
            while (sticks.Length > 1)
            {
                var shortest = PerformCut();
                SubtractShortest(shortest);
            }
        }

        private int PerformCut()
        {
            var shortest = sticks.Min();
            List<int> cutSticks = sticks.Where(i => i == shortest).ToList();

            sticks = sticks.Where(s => !cutSticks.Contains(s)).ToArray();
            if (sticks.Count() > 0) output.Add(sticks.Count());

            return shortest;
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