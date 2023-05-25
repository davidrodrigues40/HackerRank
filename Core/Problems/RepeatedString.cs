using Core.Helpers;
using System.Diagnostics;

namespace Core.Problems
{
	internal class RepeatedString : IProblem
	{
		private static Stopwatch _stopWatch = new();
		object IProblem.Solve(object input)
		{
			(string s, long n) = input.ToString_Long(',');

			return DoWork(s, n);
		}

		private static long DoWork(string s, long n)
		{

			if (s.Length == 1)
			{
				if (s == "a") return n;
				return 0;
			}

			var charArray = s.ToCharArray();

			long count = 0;
			charArray.ToList().ForEach(c => { if (c == 'a') count++; });

			IEnumerable<char> charArr = new List<char>(charArray);

			long factor = (n / s.Length);
			count = factor * count;

			long rem = (n % s.Length);
			s.Take((int)rem).ToList().ForEach(c => { if (c == 'a') count++; });

			return count;
		}
	}
}
