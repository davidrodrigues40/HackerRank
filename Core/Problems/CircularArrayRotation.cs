using Core.Helpers;

namespace Core.Problems;

public class CircularArrayRotation : IProblem
{
    public void Solve(object input)
    {

        (int[] arr1, int integer, int[] arr2) = input.ToIntArray_Int_IntArray(',', ' ');

        var rotated = DoWork(arr1.ToList(), integer, arr2.ToList());

        Console.WriteLine(string.Join('\n', rotated));
    }

    private static List<int> DoWork(List<int> a, int k, List<int> queries)
    {
        if (a.Count >= k) return LowRotations(a, k, queries);

        var mod = k % a.Count;

        return LowRotations(a, mod, queries);
    }

    private static List<int> LowRotations(List<int> a, int k, List<int> queries)
    {
        a.Reverse();

        var last = a.Skip(k);

        var first = a.Take(k);

        var rotatedList = last.Concat(first).ToList();
        rotatedList.Reverse();

        return queries.Select(q => rotatedList.ElementAt(q)).ToList();
    }
}