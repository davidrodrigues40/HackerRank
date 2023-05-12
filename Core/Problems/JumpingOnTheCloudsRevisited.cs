
using Core.Helpers;

namespace Core.Problems
{
    internal class JumpingOnTheCloudsRevisited : IProblem
    {
        public void Solve(object input)
        {
            (int[] clouds, int k) = input.ToIntArray_Int(',', ' ');
            Console.WriteLine(JumpingOnClouds(clouds, k));
        }

        /// <summary>
        /// Jumpings the on clouds.
        /// </summary>
        /// <param name="c">The clouds</param>
        /// <param name="k">The jump size per unit</param>
        /// <returns></returns>
        static int JumpingOnClouds(int[] c, int k)
        {
            var energy = 100;
            var currentStep = 0;

            do
            {
                energy--;

                currentStep += k;

                var cloud = c[currentStep % c.Length];

                if (cloud == 1)
                    energy -= 2;
            }
            while (currentStep % c.Length != 0);

            return energy;
        }
    }

    internal enum Cloud
    {
        cumulus,
        thunderhead
    }
}
