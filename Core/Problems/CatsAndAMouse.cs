using Core.Helpers;

namespace Core.Problems
{
    public class CatsAndAMouse : IProblem
    {
        public object Solve(object input)
        {
            var p = input.ToStringArray(' ');
            var list = p.ToListOfIntArrays();

            var output = new List<object>();

            foreach (var item in list)
            {
                output.Add(CatAndMouse(item[0], item[1], item[2]));
            }

            return output;
        }

        static string CatAndMouse(int x, int y, int z)
        {
            var catASteps = DetermineSteps(x, z);
            var catBSteps = DetermineSteps(y, z);

            if (catASteps == catBSteps) return "Mouse C";

            return catASteps > catBSteps ? "Cat B" : "Cat A";
        }

        static int DetermineSteps(int cat, int mouse)
        {
            if (cat > mouse)
                return StepsBack(cat, mouse);
            if (mouse > cat)
                return StepsForward(cat, mouse);

            return 0;
        }

        static int StepsForward(int cat, int mouse)
        {
            return mouse - cat;
        }

        static int StepsBack(int cat, int mouse)
        {
            return cat - mouse;
        }
    }
}
