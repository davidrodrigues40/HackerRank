using System;

namespace Core.Problems
{
    public class Staircase : IWorker
    {
        private const string _character = "#";
        public void DoWork(object s)
        {
            var size = int.Parse((string)s);
            var tier = size;
            do
            {
                var output = "";
                for (var x = 1; x <= size; x++)
                {
                    if (x >= tier)
                    {
                        output += _character;
                    }
                    else
                    {
                        output += " ";
                    }
                }
                Console.WriteLine(output);
                tier--;
            }
            while (tier > 0);
        }
    }
}
