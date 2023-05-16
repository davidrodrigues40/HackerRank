using Core.Problems;

namespace Core.Factories
{
    public static class WorkerFactory
    {
        public static IProblem? GetWorker(string problem)
        {
            string sType = $"Core.Problems.{problem}, Core";
            Type? type = Type.GetType(sType);

            if (type == null) return null;
            var instance = Activator.CreateInstance(type);

            if (instance == null) return null;

            return (IProblem)instance;
        }
    }
}
