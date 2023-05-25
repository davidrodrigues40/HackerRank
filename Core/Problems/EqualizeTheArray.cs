using Core.Helpers;

namespace Core.Problems
{
	internal class EqualizeTheArray : IProblem
	{
		public object Solve(object input)
		{
			var list = input.ToIntList(' ');

			return DoWork(list);
		}

		private int DoWork(List<int> arr)
		{
			var output = new Dictionary<int, int>();

			for (int i = 0; i < arr.Count; i++)
			{
				if (output.ContainsKey(arr[i]))
					output[arr[i]]++;
				else
					output.Add(arr[i], 1);
			}

			var most = output.Max(x => x.Value);
			return arr.Count - most;
		}
	}
}
