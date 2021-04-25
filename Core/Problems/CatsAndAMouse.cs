using Core.Helpers;
using System;

namespace Core.Problems
{
    public class CatsAndAMouse : IProblem
    {
        public void Solve(object input)
        {
            var p = input.ToStringArray(' ');
            var list = p.ToListOfIntArrays();

            foreach (var item in list)
            {
                Console.WriteLine(catAndMouse(item[0], item[1], item[2]));
            }
        }

        static string catAndMouse(int x, int y, int z)
        {
            var catASteps = determineSteps(x, z);
            var catBSteps = determineSteps(y, z);

            if (catASteps == catBSteps) return "Mouse C";

            return catASteps > catBSteps ? "Cat B" : "Cat A";
        }

        static int determineSteps(int cat, int mouse)
        {
            if (cat > mouse)
                return stepsBack(cat, mouse);
            if (mouse > cat)
                return stepsForward(cat, mouse);

            return 0;
        }

        static int stepsForward(int cat, int mouse)
        {
            return mouse - cat;
        }

        static int stepsBack(int cat, int mouse)
        {
            return cat - mouse;
        }
    }
}
