using ConsoleApp.Models;

namespace ConsoleApp.Services
{

    public class ArgParser
    {

        public Parameters GetParameters(string[] args)
        {
            var output = new Parameters();

            if (args == null || args.Length == 0)
            {
                return output;
            }

            if (args.GetValue(0) != null)
            {
                output.Problem = args[0];
            }

            if (args.Length > 0 && args.GetValue(1) != null)
            {
                output.Input = args.GetValue(1);
            }

            return output;
        }
    }
}
