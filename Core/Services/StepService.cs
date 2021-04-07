using System;

namespace Core.Services
{
    public static class StepService
    {
        public static string BuildSteps(int tiers, string outputCharacter)
        {
            var steps = tiers;
            var output = "";
            do
            {
                for (var x = 1; x <= tiers; x++)
                {
                    if (x >= steps)
                    {
                        output += outputCharacter;
                    }
                    else
                    {
                        output += " ";
                    }
                }
                output += Environment.NewLine;
                steps--;
            }
            while (steps > 0);

            return output;
        }
    }
}
